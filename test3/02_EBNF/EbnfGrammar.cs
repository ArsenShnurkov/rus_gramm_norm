using System.Collections.Generic;

public class EbnfGrammar
{
    List<EbnfRule> rules = new List<EbnfRule> ();
    Dictionary<string, EbnfNonterminal> NonTerminals = new Dictionary<string, EbnfNonterminal> ();

    public EbnfGrammar ()
    {
    }

    public IEnumerable<EbnfRule> Rules { get { return rules; } }
    public IEnumerable<EbnfNonterminal> Nonterminals { get { return NonTerminals.Values; } }

    public void Add (EbnfRule rule)
    {
        rules.Add (rule);
        var nt = rule.Nonterminal;
        if (NonTerminals.ContainsKey (nt.Name) == false) {
            NonTerminals.Add (nt.Name, nt);
        }
        nt.Add (rule);
    }

    public EbnfNonterminal this [string ruleName] {
        get {
            return NonTerminals [ruleName];
        }
    }
}

