public interface IEbnfHidingPart { }

public class EbnfHiding : AbstractOperation<IEbnfHidingPart>
{
    public EbnfHiding (IEbnfHidingPart [] parts) : base (parts)
    {
    }
}
