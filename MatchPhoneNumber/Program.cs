using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var pattern = @"( |^)\+[359]+( |-)[2]\2[\d]{3}\2[\d]{4}\b";
			var input = Console.ReadLine();
			var matches = Regex.Matches(input, pattern);
			var result = matches.Cast<Match>()
				.Select(m => m.Value.Trim())
				.ToArray();
			Console.WriteLine(string.Join(", ", result));
		}
	}
}
