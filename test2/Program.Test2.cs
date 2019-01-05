using System;

namespace test2
{
    partial class MainClass
    {
        public static EbnfGrammar Test2 ()
        {
            EbnfNonterminal S = new EbnfNonterminal (nameof (S));
            EbnfNonterminal A = new EbnfNonterminal (nameof (A));

            EbnfTerminal a = new EbnfTerminal (nameof (a));
            EbnfTerminal b = new EbnfTerminal (nameof (b));
            EbnfTerminal c = new EbnfTerminal (nameof (c));
            EbnfTerminal d = new EbnfTerminal (nameof (d));

            var rule1 = new EbnfRule (S, new EbnfEnumeration (new IEbnfEnumerationPart [] { c, A, d }));
            var rule2 = new EbnfRule (A, new EbnfEnumeration (new IEbnfEnumerationPart [] { a, b }));
            var rule3 = new EbnfRule (A, new EbnfEnumeration (new IEbnfEnumerationPart [] { a }));
            var G = new EbnfGrammar ();
            G.Add (rule1);
            G.Add (rule2);
            G.Add (rule3);
            return G;
        }
        public static void Main (string [] args)
        {
            var EG = Test2 ();
            var c = new FromEbnfToBnf_ByCopying (EG);
            var text = new SymbolReader ("cad");
            var pc = new RecursiveDescentParser (text);
            var res = pc.RecusiveDescent (c.Bnf ["S"]);
            Console.WriteLine (res);
        }
    }
}
