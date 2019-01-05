public interface IEbnfGroupingPart { }

public class EbnfGrouing : AbstractOperation<IEbnfGroupingPart>
{
    public EbnfGrouing (IEbnfGroupingPart [] parts) : base (parts)
    {
    }
}
