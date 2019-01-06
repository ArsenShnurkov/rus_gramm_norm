public interface IOperationFootprintGroup
{
    IOperationFootprint [] Parts { get; set; }
}

public interface IOperationFootprintGroup<SourcePoint, DestinationPoint> : IOperationFootprintGroup
{
    new OperationFootprint<SourcePoint, DestinationPoint> [] Parts { get; }
}

public abstract class AOperationFootprintGroup<SourcePoint, DestinationPoint> : OperationFootprint<SourcePoint, DestinationPoint>, IOperationFootprintGroup
{
    public abstract IOperationFootprint [] Parts { get; set; }
}

public class OperationFootprintGroup<SourcePoint, DestinationPoint> : OperationFootprint<SourcePoint, DestinationPoint>, IOperationFootprintGroup
{
    public OperationFootprintGroup (SourcePoint b, DestinationPoint a)
    {
        Before = b;
        After = a;
    }
    public IOperationFootprint [] Parts { get; set; }
}
