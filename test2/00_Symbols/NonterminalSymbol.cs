using System;
namespace test2
{
    public class NonterminalSymbol : ISymbol
    {
        public bool IsTerminal { get { return false; } }
        protected string n;
        public NonterminalSymbol (string name)
        {
            n = name;
        }
        public string Name { get { return n; } }
    }
}
