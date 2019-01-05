using System;
using System.Collections.Generic;

namespace test2
{
    public class EbnfRule
    {
        protected EbnfNonterminal nonterminal;
        protected IEbnfRulePart [] p;
        public EbnfRule (EbnfNonterminal nt, IEbnfRulePart [] parts)
        {
            nonterminal = nt;
            p = parts;
        }
        public EbnfNonterminal Nonterminal { get { return nonterminal; } }
        public IEnumerable<IEbnfRulePart> Parts { get { return p; } }
    }
}

