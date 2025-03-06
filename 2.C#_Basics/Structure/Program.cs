using System;
using System.Timers;

namespace Structure
{
	internal class Program
	{
		struct Employee
		{
			int EmpId;
			string Name;
			double Salary;

			public Employee(int empId, string name, double salary)
			{
				EmpId = empId;
				Name = name;
				Salary = salary;
			}
			public void show()
			{
				Console.WriteLine(EmpId + "\t" + Name + "\t" + Salary);
			}
		}
		static void Main(string[] args)
		{
			Employee e1 = new Employee(1, "Vishvajit", 800000);
			e1.show();



		}
	}
}
