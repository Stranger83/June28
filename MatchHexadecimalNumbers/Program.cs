using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = @"\b(0x)?[0-9A-F]+\b";
			var matches = Regex.Matches(input, pattern);
			var result = matches.Cast<Match>()
				.Select(m => m.Value.Trim())
				.ToArray();

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
