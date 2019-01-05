public class EbnfTerminal : TerminalSymbol,
    IEbnfRuleRightPart,
    IEbnfEnumerationPart,
    IEbnfExpressionPart
{
    public EbnfTerminal (string content) : base (content)
    {
    }
}

