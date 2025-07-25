using System;
using System.Collections.Generic;
					
public class Program
{
	static List<string> studentNames = new List<string>();
	static List<string> studentIDs = new List<string>();
	static List<List<double>> studentsGrades = new List<List<double>>();
	static List<List<string>> studentsSubjects = new List<List<string>>();
	
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
					Console.WriteLine("Invalid choice. Press Enter to continue.");
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
		Console.Write("\nChoose an option (1-5): ");
		return Console.ReadLine();
	}
	
	static void AddStudent()
	{
		Console.WriteLine("\nEnter student name: ");
		string name = Console.ReadLine();
		
		Console.WriteLine("\nEnter student ID: ");
		string id = Console.ReadLine();
		
		// Add their respective name, id and create two new lists to store their grades and subjects.
		studentNames.Add(name);
		studentIDs.Add(id);
		studentsGrades.Add(new List<double>());
		studentsSubjects.Add(new List<string>());
		
		Console.WriteLine("Student added successfully. Press Enter to continue.");
		Console.ReadLine();
	}
	
	static void AddGrade()
	{
		// Checks if has any student.
		if (studentNames.Count == 0)
		{
			Console.WriteLine("No students available, insert a student first.");
			Console.ReadLine();
			return;
		}
		
		// Show list of students and ID's.
		Console.WriteLine("Students and IDs:");
		for (int i = 0; i < studentNames.Count; i++) 
		{
			Console.WriteLine($"{i + 1}. {studentNames[i]} ({studentIDs[i]})");
		}
		
		// Select student
		Console.Write("Enter student number: ");
		// Take input and check if it is in a valid input range.
		if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= studentNames.Count)
		{
			Console.Write("\nEnter subject: ");
			string subject = Console.ReadLine();
			
			Console.Write("\nEnter grade (0-100): ");
			// Take the input and checks if it is a valid number and if it in range.
			if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
			{
				studentsGrades[index - 1].Add(grade);
				studentsSubjects[index - 1].Add(subject); // Store subject alongside grade in a list.
				Console.WriteLine("Grade added successfully.");
			}
			else
			{
				Console.WriteLine("Invalid grade.");
			}
		}
		else 
		{
			Console.WriteLine("Invalid student number.");
		}
		
		// Return to menu
		ReturnMenu();
	
	}
	
	static void CalculateAverages()
	{
		Console.WriteLine("Student Averages: ");
		for (int i = 0; i < studentNames.Count; i++)
		{	
			// Store grades on a new list to calculate the average.
			List<double> grades = studentsGrades[i];
			// Check if it has grades, if it has, pass to the function to calculate average.
			double average = grades.Count > 0 ? CalculateAverage(grades) : 0;
			Console.WriteLine($"{studentNames[i]} ({studentIDs[i]}) - Average Grade: {average}");
		}
		ReturnMenu();
	}
	
	// Calculate the average of a given grade list.
	static double CalculateAverage(List<double> grades)
	{
		// Avoiding divided by zero
		if (grades.Count == 0) 
		{
			return 0;
		}
		
		double total = 0;
		for (int i = 0; i < grades.Count; i++)
		{
			total = total + grades[i];
		}
		return  total / grades.Count;
	}
	
	static void DisplayRecords()
	{
		Console.WriteLine("\nAll Student Records");
		for (int i = 0; i < studentNames.Count; i++)
		{	
			// Output the Student and ID 
			Console.WriteLine($"\nStudent: {studentNames[i]} ({studentIDs[i]})");
			if (studentsGrades[i].Count > 0)
			{	
				// Output each subject and their grade for the current student.
				Console.WriteLine("Grades:");
				for (int j = 0; j < studentsGrades[i].Count; j++)
				{
					Console.WriteLine($"	{studentsSubjects[i][j]}: {studentsGrades[i][j]}");
				}
			}
			else
			{
				Console.WriteLine("No grades recorded.");
			}
		}
		ReturnMenu();
	}

	static void ReturnMenu()
	{
		Console.WriteLine("\nPress Enter to continue.");
		Console.ReadLine();
	}
}
