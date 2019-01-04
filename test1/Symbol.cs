using System;
namespace test1
{
    public class Symbol
    {
        public bool isTerminal { get; set; }
        protected string name_or_content;
        public Symbol ()
        {
        }
        public Symbol (string content)
        {
            isTerminal = true;
            name_or_content = content;
        }
        public string Content { get { return name_or_content; } }
    }
}

