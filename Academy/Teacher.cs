﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher:Human
	{
		static readonly int SPECIALITY_WIDTH = 24;
		static readonly int EXPERIENCE_WIDTH = 5;
		public string Speciality {  get; set; }
		public int Experience { get; set; }
		public Teacher
			(
			string lastName, string firstName, int age,
			string speciality, int experience
			):base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TeacherConstructor:\t{GetHashCode()}");
		}
		~Teacher() 
		{
			Console.WriteLine($"TeacherDestructor:\t{GetHashCode()}");
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Experience}");
		}
		public override string ToString()
		{
			return base.ToString() + $" {Speciality.PadRight(SPECIALITY_WIDTH)} {Experience.ToString().PadRight(EXPERIENCE_WIDTH)}";
		}
	}
}
