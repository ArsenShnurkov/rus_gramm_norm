public interface IEbnfRepetitinoPart { }

public class EbnfRepetition : AbstractOperation<IEbnfRepetitinoPart>
{
    public EbnfRepetition (IEbnfRepetitinoPart [] parts) : base (parts)
    {
    }
}

