public interface IEbnfExpressionPart { }

public class EbnfExpression : AbstractOperation<IEbnfExpressionPart>,
    IEbnfRuleRightPart
{
    public EbnfExpression (IEbnfExpressionPart [] parts) : base (parts)
    {
    }
}


