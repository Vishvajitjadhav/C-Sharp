using System;

namespace _2DArray
{
	internal class Program
	{
		static void twoDdemo()
		{
			int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			for(int i=0; i<3; i++)
			{
				for(int j=0; j<3; j++)
				{
					Console.Write(arr[i, j] + " ");
				}
			}

		}
		static void Main(string[] args)
		{
			twoDdemo();
		}
	}
}
