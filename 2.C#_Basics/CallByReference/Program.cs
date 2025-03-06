using System;

namespace CallByReference
{
	internal class Program
	{

		static void BookTicket(ref int x)
		{
			x--;
			Console.WriteLine(x);

		}
		static void Main(string[] args)
		{
			int tickets = 100;
			Console.WriteLine("Before booking : {0}", tickets);
			BookTicket(ref tickets);
			Console.WriteLine("After booking : {0}", tickets);
		}
	}
}
