public interface IEbnfExclusionPart { }

public class EbnfExclusion : AbstractOperation<IEbnfExclusionPart>
{
    public EbnfExclusion (IEbnfExclusionPart [] parts) : base (parts)
    {
    }
}

