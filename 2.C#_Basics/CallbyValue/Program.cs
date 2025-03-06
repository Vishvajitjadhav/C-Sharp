using System;

namespace CallbyValue
{
	internal class Program
	{

		static void BookTicket(int x)
		{
			x--;
			Console.WriteLine("tickets left: {0}", x);
		}
		static void Main(string[] args)
		{
			int tickets = 100;
			Console.WriteLine("before booking {0}", tickets);
			BookTicket(tickets);
			Console.WriteLine("After booking {0}", tickets);
		}
	}
}
