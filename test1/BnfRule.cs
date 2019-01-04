using System;
using System.Collections.Generic;

namespace test1
{
    public class BnfRule
    {
        protected BnfNonterminal nonterminal;
        protected Symbol [] parts;
        public BnfRule (BnfNonterminal nt, Symbol [] symbols_of_rule)
        {
            nonterminal = nt;
            parts = symbols_of_rule;
        }
        public BnfNonterminal Nonterminal { get { return nonterminal; } }
        public IEnumerable<Symbol> Parts { get { return parts; } }
    }
}

