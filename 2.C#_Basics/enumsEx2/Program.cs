using System;

namespace enumsEx2
{
	enum status
	{
		ordered = 10,
		shipped = 20,
		delivered = 30
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(status.ordered);
			Console.WriteLine(status.shipped);
		}
	}
}
