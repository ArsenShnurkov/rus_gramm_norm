public class TerminalSymbol : ISymbol
{
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

