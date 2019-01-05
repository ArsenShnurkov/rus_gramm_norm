using System;
namespace test2
{
    public class RuleConversionFootprint : OperationFootprint<EbnfRule, BnfRule>
    {
        public RuleConversionFootprint (EbnfRule before, BnfRule after)
        {
            base.Before = before;
            base.After = after;
        }
    }
}

