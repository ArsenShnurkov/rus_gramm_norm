using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfGroupingPart { }

    public class EbnfGrouing : AbstractOperation<IEbnfGroupingPart>
    {
        public EbnfGrouing (IEbnfGroupingPart [] parts) : base (parts)
        {
        }
    }
}

