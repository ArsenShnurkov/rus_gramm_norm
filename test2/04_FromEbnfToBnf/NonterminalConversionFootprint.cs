using System;
namespace test2
{
    public class NonterminalConversionFootprint : OperationFootprint<EbnfNonterminal, BnfNonterminal>
    {
        public NonterminalConversionFootprint (EbnfNonterminal before, BnfNonterminal after)
        {
            base.Before = before;
            base.After = after;
        }
    }
}
