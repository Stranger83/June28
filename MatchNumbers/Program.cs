using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
			var matches = Regex.Matches(input, pattern);
			var result = matches.Cast<Match>()
				.Select(m => m.Value)
				.ToArray();

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
