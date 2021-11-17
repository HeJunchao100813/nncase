using System.Linq;
using System.Collections.Immutable;
using System.Collections.Generic;
using System;
using static Nncase.Pattern.Utility;
using static Nncase.Pattern.F.Tensors;
using static Nncase.Pattern.F.Math;
using static Nncase.IR.F.Tensors;
using static Nncase.IR.F.Math;
using Nncase.Pattern;
using Nncase.IR.Tensors;
using Nncase.IR.Math;
using Nncase.IR;

namespace Nncase.Transform.Rule
{
    public class FoldInQuant : PatternRule
    {
        WildCardPattern wcin = "input";

        public FoldInQuant()
        {
            var quant = IsQuantize(wcin);
            var dequant = IsDeQuantize(quant);
            Pattern = dequant;
        }

        public override Expr? GetRePlace(IMatchResult result)
        {
            var input = result[wcin];
            var output = result.GetRoot();
            bool check = (input.CheckedType, output.CheckedType) switch
            {
                (TensorType intype, TensorType outtype) => intype.DType == outtype.DType,
                (_, _) => false
            };
            if (check)
                return input;
            return null;
        }
    }

}