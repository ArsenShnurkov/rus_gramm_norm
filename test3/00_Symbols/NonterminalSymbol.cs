public class NonterminalSymbol : ISymbol
{
    protected string n;
    public NonterminalSymbol (string name)
    {
        n = name;
    }
    public string Name { get { return n; } }
}
