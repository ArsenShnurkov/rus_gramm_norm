using System;
using System.Collections.Generic;

namespace test2
{
    public class BnfRule
    {
        protected BnfNonterminal nonterminal;
        protected ISymbol [] parts;
        public BnfRule (BnfNonterminal nt, ISymbol [] symbols_of_rule)
        {
            nonterminal = nt;
            parts = symbols_of_rule;
        }
        public BnfNonterminal Nonterminal { get { return nonterminal; } }
        public IEnumerable<ISymbol> Parts { get { return parts; } }
    }
}

