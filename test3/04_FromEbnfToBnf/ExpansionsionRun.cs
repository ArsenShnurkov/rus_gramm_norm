using System;
using System.Collections.Generic;

public class ExpansionsionRun
{
    public EbnfGrammar Before { get; set; }
    public EbnfGrammar After { get; set; }

    public OperationFootprintGroup<EbnfGrammar, EbnfGrammar> Footprint { get; set; }

    List<IOperationFootprint> ops = new List<IOperationFootprint> ();

    public ExpansionsionRun (EbnfGrammar Input)
    {
        After = Convert (Input);
    }
    EbnfGrammar Convert (EbnfGrammar input)
    {
        Before = input;
        After = new EbnfGrammar ();
        Footprint = new OperationFootprintGroup<EbnfGrammar, EbnfGrammar> (Before, After);
        foreach (var er in Before.Rules) {
            //ProcessRuleRecursivelyAddNewRulesWhenNeeded (er);
            //BnfRule br = Convert (er);
        }
        Footprint.Parts = ops.ToArray ();
        return After;
    }
}

