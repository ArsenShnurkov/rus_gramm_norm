using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Eto.Parse;
using Eto.Parse.Grammars;

namespace rus_gramm_norm
{
	class MainClass
	{
		const string nameOfTheStartingRule = "файл";
		static void Main(string[] args)
		{
			var fileContent = LoadFromResource(nameof(rus_gramm_norm), "Grammar", "syntax2.ebnf");

			EbnfStyle style = (EbnfStyle)(
				(uint)EbnfStyle.Iso14977
				//& ~(uint) EbnfStyle.WhitespaceSeparator	
				| (uint)EbnfStyle.EscapeTerminalStrings);

			EbnfGrammar grammar;
			Grammar parser;
			try
			{
				grammar = new EbnfGrammar(style);
				parser = grammar.Build(fileContent, nameOfTheStartingRule);
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
				/*
				System.ArgumentException: the topParser specified is not found in this ebnf
				  at Eto.Parse.Grammars.EbnfGrammar.Build (System.String bnf, System.String startParserName) [0x00048] in <filename unknown>:0 
				  at Globals.Main (System.String[] args) [0x0002b] in /var/calculate/remote/distfiles/egit-src/SqlParser-on-EtoParse.git/test1/Program.cs:20 
				*/
				throw;
			}

			var originalContent = LoadFromResource(nameof(rus_gramm_norm), "Grammar", "syntax1.ebnf");
			var match = parser.Match(originalContent);
			if (match.Success == false)
			{
				Console.Out.WriteLine("No luck!");
			}
			else {
				DumpAllMatches(match, nameOfTheStartingRule);
			}
		}
		public static void DumpAllMatches(Match m, string name)
		{
			for (int pos = 0; pos < m.Matches.Count; pos++)
			{
				Match nm = m.Matches[pos];

				var full_name = nm.Name + " <- " + name;

				bool low = IsTooLow(nm.Name);
				if (nm.Matches.Count == 0 || low)
				{
					if (string.Compare(nm.Name, "гм", StringComparison.InvariantCulture) == 0)
					{
						continue;
					}
					string fmt = "\"{0}\"" + Environment.NewLine + "\t" + "{1}";
					Console.WriteLine(fmt, nm.Text, full_name);
				}
				if (!low)
				{
					DumpAllMatches(nm, full_name);
				}
			}
		}
		static bool IsTooLow(string rule)
		{
			if (rule == "комментарий")
			{
				return true;
			}
			if (rule == "имя"
				 || rule == "символ из битов"
				)
			{
				return true;
			}
			return false;
		}
		public static string LoadFromResource(string default_namespace, string folder, string name_of_file)
		{
			// Resource ID: mptgitmodules.Resources.syntax4.ebnf
			var fullname = string.Format("{0}.{1}.{2}", default_namespace, folder, name_of_file);
			using (var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(fullname))
			{
				return LoadFromStream(s);
			}
		}
		public static string LoadFromStream(Stream s)
		{
			using (var sr = new StreamReader(s))
			{
				return LoadFromTextReader(sr);
			}
		}
		public static string LoadFromTextReader(TextReader sr)
		{
			var fileContent = sr.ReadToEnd();
			return fileContent;
		}
	}
}
