using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
	class Program
	{
		static void Main(string[] args)
		{
			string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

			var names = Console.ReadLine();

			MatchCollection matches = Regex.Matches(names, regex);
			foreach (Match name in matches)
			{
				Console.Write(name.Value + " ");
			}
			Console.WriteLine();
		}
	}
}
