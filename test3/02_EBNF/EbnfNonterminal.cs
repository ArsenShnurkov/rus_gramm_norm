﻿using System.Collections.Generic;

public class EbnfNonterminal : NonterminalSymbol,
    IEbnfRuleRightPart,
    IEbnfExpressionPart,
    IEbnfEnumerationPart
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

