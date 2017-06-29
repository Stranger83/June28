using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDates
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = @"(?<day>[0-9]{2})(.|-|/)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>[0-9]{4})";
			var matches = Regex.Matches(input, pattern);
			foreach (Match m in matches)
			{
				var day = m.Groups["day"].Value;
				var month = m.Groups["month"].Value;
				var year = m.Groups["year"].Value;
				Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
			}
		}
	}
}
