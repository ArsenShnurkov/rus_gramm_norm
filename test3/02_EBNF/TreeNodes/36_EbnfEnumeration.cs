public interface IEbnfEnumerationPart { }

public class EbnfEnumeration : AbstractOperation<IEbnfEnumerationPart>,
    IEbnfRuleRightPart
{
    public EbnfEnumeration (IEbnfEnumerationPart [] parts) : base (parts)
    {
    }
}


