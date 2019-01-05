public interface IOperationFootprint
{
    object Before { get; set; }
    object After { get; set; }
}

public class OperationFootprint<SourcePoint, DestinationPoint> : IOperationFootprint
{
    public SourcePoint Before { get; set; }
    public DestinationPoint After { get; set; }

    object IOperationFootprint.Before {
        get {
            return Before;
        }

        set {
            Before = (SourcePoint)value;
        }
    }

    object IOperationFootprint.After {
        get {
            return After;
        }

        set {
            After = (DestinationPoint)value;
        }
    }
}
