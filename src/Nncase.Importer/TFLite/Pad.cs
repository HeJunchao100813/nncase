// Copyright (c) Canaan Inc. All rights reserved.
// Licensed under the Apache license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Linq;
using Nncase.IR;
using Nncase.IR.Tensors;
using F = Nncase.IR.F;
using TensorType = tflite.TensorType;

namespace Nncase.Importer.TFLite
{
    public partial class TFLiteImporter
    {
        private Expr VisitPad(in tflite.Operator op)
        {
            // paddings is a Expr, Shape=[channels, 2(before, after)]
            var (input, paddings) = GetInputExprs(op, 0, 1);
            var pad_value = GetInputTensor(op, 0).Type switch
            {
                TensorType.FLOAT32 => 0.0,
                TensorType.INT8 => 0,
                TensorType.UINT8 => 128,
                _ => throw new NotSupportedException("")
            };

            return F.Tensors.Pad(input, paddings, PadMode.Constant, pad_value);
        }
    }
}