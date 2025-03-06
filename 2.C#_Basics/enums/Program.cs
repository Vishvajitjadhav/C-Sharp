using System;

namespace enums
{
	enum DaysOfWeek
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			DaysOfWeek today = DaysOfWeek.Wednesday;
			Console.WriteLine($"Today is: {today}");
		
		}
	}
}
