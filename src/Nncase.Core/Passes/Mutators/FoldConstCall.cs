﻿// Copyright (c) Canaan Inc. All rights reserved.
// Licensed under the Apache license. See LICENSE file in the project root for full license information.

using System.Collections.Immutable;
using System.Linq;
using NetFabric.Hyperlinq;
using Nncase.Evaluator;
using Nncase.IR;

namespace Nncase.Passes.Mutators;

/// <summary>
/// fold const call.
/// </summary>
public sealed class FoldConstCall : ExprRewriter
{
    /// <inheritdoc/>
    protected override Expr RewriteLeafTuple(IR.Tuple expr)
    {
        if (IsAllConst(expr.Fields))
        {
            return new TupleConst(new TupleValue(expr.Fields.AsValueEnumerable().Select(x => Value.FromConst((Const)x)).ToArray()));
        }

        return expr;
    }

    /// <inheritdoc/>
    protected override Expr RewriteLeafCall(Call expr)
    {
        if ((expr.Target is Op op && op.CanFoldConstCall) || expr.Target is Function)
        {
            if (IsAllConst(expr.Arguments))
            {
                return Const.FromValue(CompilerServices.Evaluate(expr));
            }

            if (expr.Target is IR.Tensors.GetItem && expr[IR.Tensors.GetItem.Input] is IR.Tuple tuple &&
                expr[IR.Tensors.GetItem.Index] is TensorConst { Value: Tensor index })
            {
                return tuple.Fields[index.ToScalar<int>()];
            }
        }

        return expr;
    }

    private bool IsAllConst(ReadOnlySpan<Expr> parameters) =>
      parameters.AsValueEnumerable()
        .All(e => e is Const);
}
