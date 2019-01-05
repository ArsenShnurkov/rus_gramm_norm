using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfEnumerationPart { }

    public class EbnfEnumeration : AbstractOperation<IEbnfEnumerationPart>,
        IEbnfRuleRightPart
    {
        public EbnfEnumeration (IEbnfEnumerationPart [] parts) : base (parts)
        {
        }
    }
}

