using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutDemo
{
	internal class DemoOut
	{
		public static void Add(int x, int y, out int r)
		{
			r = x + y;
		}
		public static void getdata(out int x)
		{
			x = 100;
			Console.WriteLine("Inside a method {0}", x);
		}
	}
}
