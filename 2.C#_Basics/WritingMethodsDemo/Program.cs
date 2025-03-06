using System;
using System.Net.Http.Headers;

namespace WritingMethodsDemo
{
	internal class Program
	{

		static int product(int price, int quality)
		{
			return price * quality;
		}
		static void Main(string[] args)
		{
			int price, quality;
			Console.WriteLine("Enter price, quality");
			price = Convert.ToInt32(Console.ReadLine());
			quality = Convert.ToInt32(Console.ReadLine());
			int p = product(price, quality);
			Console.WriteLine(p);
		}
	}
}
