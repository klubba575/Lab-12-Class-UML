using System;
using System.Collections.Generic;

namespace Lab_12___ClassUML
{
	class Program
	{
		static Staff staff1 = new Staff("Andy", "\t2304 Woodward Ave", "\tDetroit University", 42000.00);
		static Staff staff2 = new Staff("Dr. Andy", "\t2305 Woodward Ave", "\tDetroit Mercy University", 47000.00);
		static Student student1 = new Student("Timmy", "\t1234 Woodward Ave", "\tGrand Circus School of Hard Knocks", 3, 100.00);
		static Student student2 = new Student("Billy Bob", "\t2345 Woodward Ave", "\tUniversity of Michigan", 2, 3200.05);
		static Student student3 = new Student("Nicolas Cage", "911 Treasure Grove", "DropOut", 1, 1000000.00);

		static List<Person> persons = new List<Person> { staff1, staff2, student1, student2, student3 };
		static void Main(string[] args)
		{
			foreach (Person person in persons)
			{
				Console.WriteLine(person);
			}
			Console.WriteLine();
			Console.WriteLine();
			string userChoice = GetUserInput("Would you like to add another student or staff member? " +
				"If yes, press 1 for New Staff or 2 for New Student.  " +
				"If No, type \"No\"");

			AddNewStaffOrStudent(userChoice);
			
		}
		public static string GetUserInput(string message)
		{
			Console.WriteLine(message);
			return Console.ReadLine();
		}
		public static int ParseStringToInt(string message)
		{
			int userIntChoice = int.Parse(Console.ReadLine());
			return userIntChoice;

		}
		public static double ParseStringToDouble(string message)
		{
			double userdoubleChoice = double.Parse(Console.ReadLine());
			return userdoubleChoice;
		}
		public static void AddNewStaffOrStudent(string message)
		{
			if (message == "1")
			{
				Staff staff = new Staff();
				staff.Name = GetUserInput("Enter Name: ");
				staff.Address = GetUserInput("Enter Address: ");
				staff.School = GetUserInput("Enter School: ");
				staff.Pay = ParseStringToDouble("Enter Pay: ");

				persons.Add(staff);
			} else if (message == "2")
			{
				Student student = new Student();
				student.Name = GetUserInput("Enter Name: ");
				student.Address = GetUserInput("Enter Address: ");
				student.Program = GetUserInput("Enter Program: ");
				student.Year = ParseStringToInt("Enter Year Number: ");
				student.Fee = ParseStringToDouble("Enter Pay: ");

				persons.Add(student);
			} 
			else if (message == "No")
			{
				Console.WriteLine("Have a Great Day!");
			}
		}
		public static void AddPerson(List<string> persons, Person person)
		{
			
		}
	}
}
