# simpleGradeStudentSys

A simple, console-based **Student Grade Management System** built in C# using only lists and functions — **no OOP**, **no arrays**. Designed for learning and educational environments, such as classroom projects or basic C# practice.

---

## 🚀 Features

- ✅ Add new students with name and ID  
- ✅ Assign grades for specific subjects  
- ✅ Calculate and display the average grade per student  
- ✅ Display a detailed list of all students with their subjects and grades  
- ✅ Simple text-based menu navigation  

---

## 🧠 How It Works

This application uses:

- `List<string>` to store student names and IDs  
- `List<List<double>>` to store each student's list of grades  
- `List<List<string>>` to match each grade with its subject  
- Procedural programming (no classes or objects)

Each grade is recorded alongside a subject name, ensuring a clear one-to-one relationship for later display or analysis.

---

## 🔁 Program Flowchart

![Flowchart of Program Logic](diagram/simpleGradeStudentSys.svg)

This flowchart illustrates the main menu-driven program flow, showing how users navigate between options like adding students, assigning grades, viewing averages, and exiting the application.

---

## 🖥 Example Usage

    Student Grade Management System
    1. Add new student
    2. Add grades to student
    3. Calculate average grades
    4. Display all records
    5. Exit
    Choose an option (1-5):

Sample output when viewing records:

    Student: Richard (01)
    Grades:
      Math: 85
      Science: 92

    Student: Bob (69)
    No grades recorded.

---

## 📂 Folder Structure

    simpleGradeStudentSys/
    ├── Program.cs              # Main C# source code file
    ├── diagram/
    │   └── simpleGradeStudentSys.svg    # Flowchart image
    └── README.md               # Project description and usage info

---

## 🔧 Requirements

- .NET SDK (Core or Framework)  
- C# compiler or IDE like Visual Studio / VS Code  

To run the app:

    dotnet run

---

## 🎓 Purpose

This project was created for educational purposes, to practice procedural C# programming, data handling with lists, and console app development — all without using object-oriented programming.

---

## 📃 License

This project is open-source and available under the [MIT License](LICENSE).

---

## 🙋‍♂️ Author

Created with ❤️ by Richard Oliveira ✨
Feel free to contribute or fork for learning purposes.
