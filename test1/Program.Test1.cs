using System;

namespace test1
{
    partial class MainClass
    {
        public static BnfGrammar Test1 ()
        {
            BnfNonterminal S = new BnfNonterminal (nameof (S));
            BnfNonterminal A = new BnfNonterminal (nameof (A));
            Symbol a = new Symbol (nameof (a));
            Symbol b = new Symbol (nameof (b));
            Symbol c = new Symbol (nameof (c));
            Symbol d = new Symbol (nameof (d));
            var rule1 = new BnfRule (S, new Symbol [] { c, A, d });
            var rule2 = new BnfRule (A, new Symbol [] { a, b });
            var rule3 = new BnfRule (A, new Symbol [] { a });
            var G = new BnfGrammar ();
            G.Add (rule1);
            G.Add (rule2);
            G.Add (rule3);
            return G;
        }
    }
}
