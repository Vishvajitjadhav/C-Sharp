using System;

namespace JaggedArray
{
	internal class Program
	{
		static void JaggedArray()
		{
			int[][] arr = new int[2][];
			arr[0] = new int[4] { 1, 2, 3, 4 };
			arr[1] = new int[2] { 1, 2 };

			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = 0; j < arr.Length; j++)
				{
					Console.Write(arr[i][j] + " ");
				}
			}

		}
		static void Main(string[] args)
		{
			JaggedArray();
		}
	}
}
