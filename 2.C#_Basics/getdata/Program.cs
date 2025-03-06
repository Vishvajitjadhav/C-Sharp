using System;

namespace getdata
{
	internal class Program
	{
		static void getdata(int[] arr)
		{
			foreach(int i in arr)
			{
				Console.WriteLine(i);
			}
		}
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			int[] arr1 = new int[3];
			arr1[0] = 345;
			arr1[1] = 234;
			arr1[2] = 456;
			getdata(arr);
			getdata(arr1);
		}
	}
}
