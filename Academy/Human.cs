using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{
		public string LastName {  get; set; }
		public string FirstName { get; set; }
		public int Age {  get; set; }

		//constructors
		public Human(string lastName, string firstName, int age) 
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HumanConstructor:\t{GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HumanDestructor:\t{GetHashCode()}");
		}
		public virtual void Print()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
		public override string ToString()
		{
			return base.ToString() + $": {LastName} {FirstName} {Age}";
		}
	}
}
