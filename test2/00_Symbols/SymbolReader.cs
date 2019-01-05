using System;
namespace test2
{
    public class SymbolReader
    {
        string t = "cad";

        public SymbolReader (string test)
        {
            t = test;
        }
        public int Position { get; set; }
        public TerminalSymbol GetSymbol ()
        {
            string res = t.Substring (Position, 1);
            Position++;
            return new TerminalSymbol (res);
        }
    }
}
