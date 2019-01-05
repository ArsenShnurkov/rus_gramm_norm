public interface IEbnfRuleRightPart { }

public class EbnfRule
{
    protected EbnfNonterminal nonterminal;
    protected IEbnfRuleRightPart p;
    public EbnfRule (EbnfNonterminal nt, IEbnfRuleRightPart rightPart)
    {
        nonterminal = nt;
        p = rightPart;
    }
    public EbnfNonterminal Nonterminal { get { return nonterminal; } }
    public IEbnfRuleRightPart RightPart { get { return p; } }
}
