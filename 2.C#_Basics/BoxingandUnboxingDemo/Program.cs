using System;

namespace BoxingandUnboxingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a, b;
			Console.WriteLine("Enter Value for a");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Value for b");
			b = Convert.ToInt32(Console.ReadLine());
			swap(ref a, ref b);  // Use 'ref' to pass by reference
			Console.WriteLine("After swapping, value for a: {0}", a);
			Console.WriteLine("After swapping, value for b: {0}", b);
		}

		public static void swap(ref int a, ref int b)
		{
			int c;
			c = a;
			a = b;
			b = c;
			Console.WriteLine("Inside swap method - After swapping, value for a: {0}", a);
			Console.WriteLine("Inside swap method - After swapping, value for b: {0}", b);
		}
	}
}
