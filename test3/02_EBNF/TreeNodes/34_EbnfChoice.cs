public interface IEbnfChoicePart { }

public class EbnfChoice : AbstractOperation<IEbnfChoicePart>,
    IEbnfEnumerationPart
{
    public EbnfChoice (IEbnfChoicePart [] parts) : base (parts)
    {
    }
}

