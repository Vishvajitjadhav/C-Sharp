using System;

namespace Params
{
	internal class Program
	{
		static void printsum(params int[] x)
		{
			int sum = 0;
			foreach(int i in x)
			{
				sum += i;
			}
			Console.WriteLine(sum);

		}

		static void Display_name(params string[] name)
		{
			foreach(string i in name)
			{
				Console.WriteLine(i);
			}
		}

		static void Main(string[] args)
		{
			printsum(1, 2, 3, 4, 5, 6, 7, 8, 9);
			printsum(234, 456, 678);
			Console.WriteLine("-------------------------------");
			Display_name("Vishvajit", "Bhakti", "Shree");
			Display_name("Sunil", "Ranjit", "Ripunjay");
		}
	}
}
