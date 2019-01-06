public interface IEbnfEnumerationPart { }

public class EbnfEnumeration : AbstractOperation<IEbnfEnumerationPart>,
    IEbnfRuleRightPart,
    IEbnfEnumerationPart
{
    public EbnfEnumeration (IEbnfEnumerationPart [] parts) : base (parts)
    {
    }
}
