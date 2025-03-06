using System;

namespace C_Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string name, course;
			Console.WriteLine("Enter name, course");
			name = Console.ReadLine();
			course = Console.ReadLine();
			Console.WriteLine("name is " + name);
			Console.WriteLine("course is " + course);
			//placeholder syntax
			Console.WriteLine("name is {0}, course is {1}", name, course);

			int a = 100;
			double p = 10.6;
			char ch = 'A';
			Console.WriteLine("c = {0}, p = {1}, a = {2}", ch, p, a);

		}
	}
}
