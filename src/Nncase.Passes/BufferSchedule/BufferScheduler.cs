﻿// Copyright (c) Canaan Inc. All rights reserved.
// Licensed under the Apache license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using Google.OrTools.Sat;
using NetFabric.Hyperlinq;
using Nncase;
using Nncase.IR;

namespace Nncase.Passes.BufferSchedule;

internal sealed class BufferScheduler
{
    public IReadOnlyDictionary<Expr, ScheduleBuffer> CollectLifeTime(Function func)
    {
        var c = new LifeTimeCollector();
        return c.Collect(func);
    }

    public void Schedule(IReadOnlyDictionary<Expr, ScheduleBuffer> bufferMap)
    {
        var model = new CpModel();
        var noOverlap = model.AddNoOverlap2D();
        var boxs = new Dictionary<Expr, (IntervalVar X, IntervalVar Y)>(ReferenceEqualityComparer.Instance);
        var timeMap = new Dictionary<int, List<Expr>>();
        var yStarts = new List<IntVar>();
        foreach (var (expr, item) in bufferMap)
        {
            var xInterval = model.NewIntervalVar(model.NewConstant(item.Interval.Brith), model.NewConstant(item.Interval.Size), model.NewConstant(item.Interval.Death), item.Name + $"{item.Number}_x");

            var upbound = 2147483648 - item.Span.End;
            if (upbound <= 0)
            {
                throw new System.NotSupportedException();
            }

            var memStartVar = model.NewIntVar(0, upbound, $"{item.Name}_{item.Number}_y_start");
            var yInterval = model.NewFixedSizeIntervalVar(memStartVar, item.Span.End, $"{item.Name}_{item.Number}_y");
            noOverlap.AddRectangle(xInterval, yInterval);
            yStarts.Add(memStartVar);
            boxs.Add(expr, (xInterval, yInterval));

            for (int time = item.Interval.Brith; time < item.Interval.Death; time++)
            {
                if (!timeMap.TryGetValue(time, out var timelist))
                {
                    timelist = new();
                    timeMap.Add(time, timelist);
                }

                timelist.Add(expr);
            }
        }

        foreach (var (expr, item) in bufferMap)
        {
            if (expr is Call { Target: IR.Tensors.Concat } concatCall && concatCall.Arguments[0] is IR.Tuple tuple)
            {
                // the concat inputs must contiguous
                int offset = 0;
                for (int i = 0; i < tuple.Fields.Length; i++)
                {
                    model.Add((boxs[concatCall].Y.StartExpr() + offset) == boxs[tuple.Fields[i]].Y.StartExpr());
                    offset += bufferMap[tuple.Fields[i]].Span.Size;
                }
            }
            else if (expr is Call { Target: IR.Tensors.Split } splitCall)
            {
                // the split must equal with input.
                model.Add(boxs[splitCall].Y.StartExpr() == boxs[splitCall.Arguments[0]].Y.StartExpr());

                // the split outputs must contiguous
                var users = splitCall.GetUsers();
                int offset = 0;
                foreach (var user in users.OrderBy(e => ((Call)e).Arguments[1].Evaluate().AsTensor().ToScalar<int>()))
                {
                    model.Add((boxs[splitCall].Y.StartExpr() + offset) == boxs[user].Y.StartExpr());
                    offset += bufferMap[user].Span.Size;
                }
            }
            else if (expr is Call { Target: IR.Tensors.Reshape } reshapCall)
            {
                // the reshape must equal with it's input.
                model.Add(boxs[reshapCall].Y.StartExpr() == boxs[reshapCall.Arguments[0]].Y.StartExpr());
            }
        }

        model.Minimize(LinearExpr.Sum(yStarts));

        var solver = new CpSolver();
        solver.StringParameters = $"max_time_in_seconds:{60},num_workers:{8}";
        CpSolverStatus solve_status = solver.Solve(model);
        if (solve_status != CpSolverStatus.Optimal && solve_status != CpSolverStatus.Feasible)
        {
            throw new System.NotSupportedException();
        }

        foreach (var (k, v) in bufferMap)
        {
            bufferMap[k].Span.Start = checked((int)solver.Value(boxs[k].Y.StartExpr()));
            bufferMap[k].Span.End = checked((int)solver.Value(boxs[k].Y.EndExpr()));
        }
    }

    public void Dump(Stream fs, IReadOnlyDictionary<Expr, ScheduleBuffer> buffers)
    {
        using (var wr = new StreamWriter(fs))
        {
            wr.Write(@"from bokeh.models import ColumnDataSource, HoverTool, FuncTickFormatter, SingleIntervalTicker, SaveTool, WheelZoomTool, WheelPanTool, ResetTool
from bokeh.palettes import Category20_20 as palette
from bokeh.plotting import figure, show, save
import itertools
from dataclasses import dataclass
from enum import Enum
from typing import List

@dataclass
class TimeInterval():
  start: int
  end: int
  def __str__(self) -> str:
    return f'(start: {self.start}, end {self.end})'

@dataclass
class MemSpan():
  depth_start: int
  depth_end: int
  def __str__(self) -> str:
    return f'(start: {self.depth_start}, size {self.depth_end - self.depth_start})'

class ConstraintsMode(Enum):
  No = 0
  Channel = 1

@dataclass
class ScheduledBuffer():
  name: str
  number: int
  interval: TimeInterval
  location: MemSpan
  constraints: ConstraintsMode
  shape: List[int]
  stride: List[int]
  inplace: bool

colors = itertools.cycle(palette)

buffers = [
");
            foreach (var (_, v) in buffers)
            {
                wr.WriteLine(v.ToString() + ",");
            }

            wr.Write(@"]

source = {
    'name': [],
    'x': [],
    'y': [],
    'width': [],
    'height': [],
    'alpha': [],
    'color': [],
    'location': [],
    'interval': [],
    'shape': [],
    'stride': [],
}

y_range_max = 0
x_range_max = 0
color_dict = {}
for buffer in buffers:
  source['name'].append(buffer.name)
  width = buffer.interval.end - buffer.interval.start
  x = buffer.interval.start + (width / 2)
  height = buffer.location.depth_end - buffer.location.depth_start
  y = buffer.location.depth_start + (height / 2)
  y_range_max = max(y_range_max, y)
  x_range_max = max(x_range_max, buffer.interval.end)
  source['x'].append(x)
  source['y'].append(y)
  source['width'].append(width)
  source['height'].append(height)
  color = color_dict.get(buffer.name)
  if color == None:
    color = next(colors)
    color_dict[buffer.name] = color
  source['color'].append(color)
  source['alpha'].append(0.2 if buffer.inplace else 1.0)
  source['interval'].append(str(buffer.interval))
  source['location'].append(str(buffer.location))
  source['shape'].append(','.join([str(s) for s in buffer.shape]))
  source['stride'].append(','.join([str(s) for s in buffer.stride]))

source = ColumnDataSource(source)
hover = HoverTool(tooltips=[('name', '@name'), ('interval', '@interval'), ('location', '@location'),
                            ('shape', '@shape'), ('stride', '@stride')])

p = figure(tools=[hover, WheelPanTool(), SaveTool(), WheelZoomTool(), ResetTool()], width=1280, height=720,
           y_range=(0, y_range_max * 1.2), x_range=(-1, x_range_max + 1),
           title='Local Buffer LifeTime (by Steps)')
p.rect(x='x', y='y', width='width', height='height', fill_color='color', legend_field='name', fill_alpha='alpha', source=source)
p.xaxis.axis_label = 'Time (steps)'
p.outline_line_color = None

show(p)");
        }
    }
}
