using System;

namespace Addition
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
			Console.WriteLine("Enter a Number");
			a = (int)Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter b number");
			b = Convert.ToInt32(Console.ReadLine());
			c = a + b;
			Console.WriteLine("A = {0} \t b = {1}", a, b);
			Console.WriteLine("Ans = {0}", c);
			Console.WriteLine("Addition of a={0} & b={1} is c={2}", a,b,c);


			double x;
			char ch;
			char flag;
			string dept;
			Console.WriteLine("Enter Float value");
			x = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(x);

			Console.WriteLine("Enter a Character");
			ch = Convert.ToChar(Console.ReadLine());
			Console.WriteLine(ch);

			Console.WriteLine("Enter a String");
			dept = Console.ReadLine();
			Console.WriteLine(dept);
		}
	}
}
