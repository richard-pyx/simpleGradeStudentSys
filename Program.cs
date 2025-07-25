using System;
using System.Collections.Generic;
					
public class Program
{
	static List<string> studentName = new List<string>();
	static List<string> studentIDs = new List<string>();
	static List<List<double>> studentGrades = new List<List<double>>();
	
	public static void Main()
	{
		while (true)
		{
			string choice = DisplayMenu();
			
			switch (choice)
			{
				case "1":
					AddStudent();
					break;
				case "2":
					AddGrade();
					break;
				case "3":
					CalculateAverages();
					break;
				case "4":
					DisplayRecords();
					break;
				case "5":
					return;
				default:
					Console.WriteLine("Invalid choice. Presse Enter to continue.");
					Console.ReadLine();
					break;
			}
		}
		
	}
	
	static string DisplayMenu()
	{
		Console.Clear();
		Console.WriteLine("Student Grade Management System");
		Console.WriteLine("1. Add new student");
		Console.WriteLine("2. Add grades to student");
		Console.WriteLine("3. Calculate average grades");
		Console.WriteLine("4. Display all records");
		Console.WriteLine("5. Exit");
		Console.WriteLine("Choose an option (1-5): ");
		return Console.ReadLine();
	}
	
	static void AddStudent()
	{
	
	}
	static void AddGrade()
	{
	
	}
	static void CalculateAverages()
	{
	
	}
	static void DisplayRecords()
	{
		
	}
	
}
