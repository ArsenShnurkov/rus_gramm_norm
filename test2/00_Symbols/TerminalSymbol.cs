using System;
namespace test2
{
    public class TerminalSymbol : ISymbol
    {
        public bool IsTerminal { get { return true; } }

        protected string c;

        public TerminalSymbol (string content)
        {
            c = content;
        }

        public string Content { get { return c; } }

        public static int Compare (TerminalSymbol sym, TerminalSymbol inputSymbol)
        {
            return string.Compare (sym.c, inputSymbol.c);
        }
    }
}

