using System;
namespace test2
{
    public class RecursiveDescentParser
    {
        SymbolReader r;
        public RecursiveDescentParser (SymbolReader reader)
        {
            r = reader;
        }
        public bool RecusiveDescent (BnfNonterminal t)
        {
            int rulesCount = t.RulesCount;
            bool [] success = new bool [rulesCount];
            int i = 0;
            foreach (var rule in t.Rules) {
                var currentPosition = r.Position;
                success [i] = true;
                foreach (var sym in rule.Parts) {
                    if (sym is NonterminalSymbol) {
                        if (RecusiveDescent (sym as BnfNonterminal) == false) {
                            success [i] = false;
                            break;
                        }
                    } else {
                        var inputSymbol = r.GetSymbol ();
                        if (TerminalSymbol.Compare (sym as TerminalSymbol, inputSymbol) == 0) {
                            continue;
                        } else {
                            success [i] = false;
                            break;
                        }
                    }
                }
                if (success [i] == false) {
                    r.Position = currentPosition;
                }
                i++;
            }
            int total = 0;
            foreach (var b in success) {
                if (b) total++;
            }
            if (total > 1) {
                throw new ApplicationException ();
            }
            return total == 1;
        }
    }
}

