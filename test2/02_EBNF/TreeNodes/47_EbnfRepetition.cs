using System;
using System.Collections.Generic;

namespace test2
{
    public interface IEbnfRepetitinoPart { }

    public class EbnfRepetition : AbstractOperation<IEbnfRepetitinoPart>
    {
        public EbnfRepetition (IEbnfRepetitinoPart [] parts) : base (parts)
        {
        }
    }
}

