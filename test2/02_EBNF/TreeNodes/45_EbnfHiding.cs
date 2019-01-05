using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfHidingPart { }

    public class EbnfHiding : AbstractOperation<IEbnfHidingPart>
    {
        public EbnfHiding (IEbnfHidingPart [] parts) : base (parts)
        {
        }
    }
}

