public class GrammarConversionFootprint : OperationFootprintGroup<EbnfGrammar, BnfGrammar>
{
    public GrammarConversionFootprint (EbnfGrammar before, BnfGrammar after)
    {
        base.Before = before;
        base.After = after;
    }
    public override IOperationFootprint [] Parts { get; set; }
}

