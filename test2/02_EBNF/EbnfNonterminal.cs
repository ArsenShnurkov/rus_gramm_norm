using System;
using System.Collections.Generic;

namespace test2
{
    public class EbnfNonterminal : NonterminalSymbol
    {
        Dictionary<EbnfRule, EbnfRule> rules = new Dictionary<EbnfRule, EbnfRule> ();
        public EbnfNonterminal (string name) : base (name)
        {
        }
        public IEnumerable<EbnfRule> Rules { get { return rules.Values; } }
        public void Add (EbnfRule rule)
        {
            if (rules.ContainsKey (rule) == false) {
                rules.Add (rule, rule);
            }
        }
        public int RulesCount { get { return rules.Count; } }
    }
}

