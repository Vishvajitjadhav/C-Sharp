using System;

namespace RefOutDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x;
			DemoOut.getdata(out x);
			Console.WriteLine(x);
			int a = 100, b = 200, c;
			DemoOut.Add(a, b, out c);
			Console.WriteLine(c);
		}
	}
}
