using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___ClassUML
{
	class Student: Person
	{
		public string Program { get; set; }
		public int Year { get; set; }
		public double Fee { get; set; }

		public Student()
		{

		}
		public Student(string name, string address, string program, int year, double fee)
			: base (name, address)
		{
			this.Program = program;
			this.Year = year;
			this.Fee = fee;
		}
		public override string ToString()
		{
			string studentThing = ($"The student's name is {Name}, their address is {Address}, their program is {Program}, " +
				$" their year is {Year}, and their fee is {Fee}");
			return studentThing;
		}
	}
}
