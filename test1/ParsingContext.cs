using System;
namespace test1
{
    public class ParsingContext
    {
        BnfGrammar g;
        string text = "cad";
        int position = 0;

        public ParsingContext (BnfGrammar grammar)
        {
            g = grammar;
        }

        public bool RecusiveDescent (BnfNonterminal t)
        {
            int rulesCount = t.RulesCount;
            bool [] success = new bool [rulesCount];
            int i = 0;
            foreach (var rule in t.Rules) {
                int currentPosition = position;
                success [i] = true;
                foreach (var sym in rule.Parts) {
                    if (sym.isTerminal == false) {
                        if (RecusiveDescent (sym as BnfNonterminal) == false) {
                            success [i] = false;
                            break;
                        }
                    } else {
                        int len = sym.Content.Length;
                        if (string.Compare (sym.Content, text.Substring (position, len)) == 0) {
                            position += len;
                            continue;
                        } else {
                            success [i] = false;
                            break;
                        }
                    }
                }
                if (success [i] == false) {
                    position = currentPosition;
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

