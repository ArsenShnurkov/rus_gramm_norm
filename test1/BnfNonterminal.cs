using System;
using System.Collections.Generic;

namespace test1
{
    public class BnfNonterminal : Symbol
    {
        Dictionary<BnfRule, BnfRule> rules = new Dictionary<BnfRule, BnfRule> ();
        public BnfNonterminal (string name) : base ()
        {
            this.isTerminal = false;
            base.name_or_content = name;
        }
        public string Name { get { return base.name_or_content; } }
        public IEnumerable<BnfRule> Rules { get { return rules.Values; } }
        public void Add (BnfRule rule)
        {
            if (rules.ContainsKey (rule) == false) {
                rules.Add (rule, rule);
            }
        }
        public int RulesCount { get { return rules.Count; } }
    }
}

