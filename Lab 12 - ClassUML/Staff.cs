using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___ClassUML
{
	class Staff: Person
	{
		//properties
		public string School { get; set; }
		public double Pay { get; set; }
		
		public Staff()
		{

		}
		public Staff(string name, string address, string school, double pay): base(name, address)
		{
			this.School = school;
			this.Pay = pay;
		}
		public override string ToString()
		{
			string staffThing = base.ToString() + ($" School: {School}, Pay: {Pay}");
			return staffThing;
		}
		
	}
}
