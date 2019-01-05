using System.Collections.Generic;

public class BnfNonterminal : NonterminalSymbol
{
    Dictionary<BnfRule, BnfRule> rules = new Dictionary<BnfRule, BnfRule> ();

    public BnfNonterminal (string name) : base (name)
    {
    }

    public IEnumerable<BnfRule> Rules { get { return rules.Values; } }

    public void Add (BnfRule rule)
    {
        if (rules.ContainsKey (rule) == false) {
            rules.Add (rule, rule);
        }
    }

    public int RulesCount { get { return rules.Count; } }
}

