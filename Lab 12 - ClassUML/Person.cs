using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___ClassUML
{
	class Person
	{
		//properties
		public string Name { get; set; }
		public string Address { get; set; }

		public Person()
		{

		}
		public Person(string name, string address)
		{
			this.Name = name;
			this.Address = address;
		}
		public override string ToString()
		{
			string personThing = ($"Name: {Name}, Address: {Address}, ");
			return personThing;
		}
	}
}
