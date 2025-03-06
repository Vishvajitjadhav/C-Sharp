using System;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[3] {1, 2, 3 };	
			for(int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}

			double[] price = new double[3];
			price[0] = 250;
			price[1] = 500;
			price[2] = 550;
			for(int i = 0;i < arr.Length;i++)
			{
				Console.WriteLine(price[i]);
			}

			foreach(int i in price)
			{
				Console.WriteLine(i);
			}

		}
	}
}
