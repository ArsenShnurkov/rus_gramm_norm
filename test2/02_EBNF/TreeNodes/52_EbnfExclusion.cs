using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfExclusionPart { }

    public class EbnfExclusion : AbstractOperation<IEbnfExclusionPart>
    {
        public EbnfExclusion (IEbnfExclusionPart [] parts) : base (parts)
        {
        }
    }
}

