using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfExpressionPart { }

    public class EbnfExpression : AbstractOperation<IEbnfExpressionPart>
    {
        public EbnfExpression (IEbnfExpressionPart [] parts) : base (parts)
        {
        }
    }
}

