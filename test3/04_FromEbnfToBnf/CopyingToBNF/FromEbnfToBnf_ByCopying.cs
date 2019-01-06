using System;
using System.Collections.Generic;

public class FromEbnfToBnf_ByCopying
{
    public OperationFootprintGroup<EbnfGrammar, BnfGrammar> Footprint { get; set; }
    public BnfGrammar Bnf { get; set; }

    Dictionary<EbnfNonterminal, NonterminalConversionFootprint> nonterminalConversions = new Dictionary<EbnfNonterminal, NonterminalConversionFootprint> ();
    Dictionary<EbnfRule, RuleConversionFootprint> ruleConversions = new Dictionary<EbnfRule, RuleConversionFootprint> ();

    List<IOperationFootprint> ops = new List<IOperationFootprint> ();

    public FromEbnfToBnf_ByCopying (EbnfGrammar EG)
    {
        Convert (EG);
    }

    BnfNonterminal Convert (EbnfNonterminal E)
    {
        BnfNonterminal B = null;
        if (nonterminalConversions.ContainsKey (E)) {
            var footprint = nonterminalConversions [E];
            B = footprint.After;
        } else {
            B = Bnf.AddNonterminal (E.Name);
            var footprint = new NonterminalConversionFootprint (E, B);
            nonterminalConversions.Add (E, footprint);
            ops.Add (footprint);
        }
        return B;
    }

    BnfRule Convert (EbnfRule E)
    {
        BnfRule B = null;
        if (ruleConversions.ContainsKey (E)) {
            var footprint = ruleConversions [E];
            B = footprint.After;
        } else {
            BnfNonterminal bn = Convert (E.Nonterminal);

            List<ISymbol> terms = new List<ISymbol> ();
            var p = E.RightPart;
            if (p is EbnfEnumeration) {
                foreach (var pp in ((EbnfEnumeration)p).Parts) {
                    if (pp is EbnfNonterminal) {
                        var name = (pp as EbnfNonterminal).Name;
                        var node = Bnf.AddNonterminal (name);
                        terms.Add (node);
                    } else {
                        if (pp is EbnfTerminal) {
                            var node = (TerminalSymbol)pp;
                            terms.Add (node);
                        } else
                            throw new ApplicationException ();
                    }
                }
            } else {
                if (p is EbnfNonterminal) {
                    var name = (p as EbnfNonterminal).Name;
                    var node = Bnf.AddNonterminal (name);
                    terms.Add (node);
                } else {
                    if (p is EbnfTerminal) {
                        var node = (TerminalSymbol)p;
                        terms.Add (node);
                    } else
                        throw new ApplicationException ();
                }
            }

            B = new BnfRule (bn, terms.ToArray ());
            bn.Add (B);
            var footprint = new RuleConversionFootprint (E, B);
            ruleConversions.Add (E, footprint);
            ops.Add (footprint);
        }
        return B;
    }

    BnfGrammar Convert (EbnfGrammar EG)
    {
        Bnf = new BnfGrammar ();
        Footprint = new OperationFootprintGroup<EbnfGrammar, BnfGrammar> (EG, Bnf);
        foreach (var er in EG.Rules) {
            BnfRule br = Convert (er);
        }
        Footprint.Parts = ops.ToArray ();
        return Bnf;
    }
}
