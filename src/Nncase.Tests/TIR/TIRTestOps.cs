﻿// Copyright (c) Canaan Inc. All rights reserved.
// Licensed under the Apache license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Nncase.Evaluator;
using Nncase.IR;
using Nncase.TIR;
using Xunit;

namespace Nncase.Tests.TIRTest;

public sealed class ExtraW : Op
{
    public static readonly ParameterInfo Input = new(typeof(ExtraW), 0, "inputs", TypePatternUtility.IsIntegralScalar());

    public override bool CanFoldConstCall => false;
}

public sealed class ExtraWEvaluator : Evaluator.ITypeInferencer<ExtraW>
{
    public IRType Visit(ITypeInferenceContext context, ExtraW target) => TupleType.Void;
}

public sealed class LoadT : Op
{
    public static readonly ParameterInfo DdrPp = new(typeof(LoadT), 0, "ddr_pp", TypePatternUtility.IsTensor() | TypePatternUtility.IsAnyType());
    public static readonly ParameterInfo GlbPp = new(typeof(LoadT), 1, "glb_pp", TypePatternUtility.IsTensor() | TypePatternUtility.IsAnyType());

    public override bool CanFoldConstCall => false;
}

public sealed class LoadTEvaluator : Evaluator.ITypeInferencer<LoadT>
{
    public IRType Visit(ITypeInferenceContext context, LoadT target) => TupleType.Void;
}
