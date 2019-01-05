using System;
using System.Collections.Generic;

namespace test2
{
    public class BnfGrammar
    {
        List<BnfRule> rules = new List<BnfRule> ();
        Dictionary<string, BnfNonterminal> NonTerminals = new Dictionary<string, BnfNonterminal> ();

        public BnfGrammar ()
        {
        }

        public IEnumerable<BnfRule> Rules { get { return rules; } }
        public IEnumerable<BnfNonterminal> Nonterminals { get { return NonTerminals.Values; } }

        public void Add (BnfRule rule)
        {
            rules.Add (rule);
            var nt = rule.Nonterminal;
            if (NonTerminals.ContainsKey (nt.Name) == false) {
                NonTerminals.Add (nt.Name, nt);
            }
            nt.Add (rule);
        }
        public BnfNonterminal this [string name] {
            get {
                return NonTerminals [name];
            }
        }
        public BnfNonterminal AddNonterminal (string name)
        {
            if (NonTerminals.ContainsKey (name)) {
                return NonTerminals [name];
            }
            var nt = new BnfNonterminal (name);
            NonTerminals.Add (name, nt);
            return nt;
        }
    }
}

