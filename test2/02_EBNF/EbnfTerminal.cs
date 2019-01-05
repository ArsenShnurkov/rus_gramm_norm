using System;
namespace test2
{
    public class EbnfTerminal : TerminalSymbol,
        IEbnfRuleRightPart,
        IEbnfEnumerationPart
    {
        public EbnfTerminal (string content) : base (content)
        {
        }
    }
}

