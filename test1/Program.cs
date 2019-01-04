using System;

namespace test1
{
    partial class MainClass
    {
        public static void Main (string [] args)
        {
            var G = Test1 ();
            var pc = new ParsingContext (G);
            var res = pc.RecusiveDescent (G ["S"]);
            Console.WriteLine (res);
        }
    }
}
