//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antoshka", 25);
			human.Print();
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher);

			Graduate graduate = new Graduate("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96, "How to using dope");
			//graduate.Print();
			Console.WriteLine(graduate);
#endif
			Human[] group = new Human[]
			{
				new Human("Montana", "Antoshka", 25),
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96, "How to using dope")				
			};

			foreach (Human human in group)
			{
				Console.WriteLine(human);
			}

			StreamWriter sw = new StreamWriter("File.txt");
			foreach (Human human in group)
			{			
				sw.WriteLine(human);
			}
			sw.Close();			
			Process.Start("notepad", "File.txt");			
			
			StreamReader sr = new StreamReader("File.txt");
			while (!sr.EndOfStream)
			{				
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);	
			}
			sr.Close();
		}
	}
}
