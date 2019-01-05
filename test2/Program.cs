using System;

namespace test2
{
    partial class MainClass
    {
        public static BnfGrammar Test1 ()
        {
            BnfNonterminal S = new BnfNonterminal (nameof (S));
            BnfNonterminal A = new BnfNonterminal (nameof (A));

            TerminalSymbol a = new TerminalSymbol (nameof (a));
            TerminalSymbol b = new TerminalSymbol (nameof (b));
            TerminalSymbol c = new TerminalSymbol (nameof (c));
            TerminalSymbol d = new TerminalSymbol (nameof (d));

            var rule1 = new BnfRule (S, new ISymbol [] { c, A, d });
            var rule2 = new BnfRule (A, new ISymbol [] { a, b });
            var rule3 = new BnfRule (A, new ISymbol [] { a });
            var G = new BnfGrammar ();
            G.Add (rule1);
            G.Add (rule2);
            G.Add (rule3);
            return G;
        }
        public static void Main1 (string [] args)
        {
            var G = Test1 ();
            var text = new SymbolReader ("cad");
            var pc = new RecursiveDescentParser (text);
            var res = pc.RecusiveDescent (G ["S"]);
            Console.WriteLine (res);
        }
    }
}
