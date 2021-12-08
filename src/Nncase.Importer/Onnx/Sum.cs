// Copyright (c) Canaan Inc. All rights reserved.
// Licensed under the Apache license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using LanguageExt.UnsafeValueAccess;
using Nncase.IR;
using Nncase.IR.Tensors;
using Onnx;
using F = Nncase.IR.F;

namespace Nncase.Importer
{
    public partial class OnnxImporter
    {
        private Expr VisitSum(NodeProto op)
        {
            return Enumerable.Range(0, op.Input.Count)
                .Select(x => GetInputExpr(op, x))
                .Fold((Expr)0, (sum, x) => F.Math.Binary(BinaryOp.Add, sum, x));
        }
    }
}