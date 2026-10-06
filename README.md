# StudentTrack - Student Management System

A simple, interactive C# Console Application designed to demonstrate fundamental C# programming concepts. This project is ideal for fresher interviews, as it covers a broad range of core concepts in a clean, structured way.

## Features
- **Add student**: Create new student records with ID, Name, Age, and Mark.
- **View all students**: Display a formatted list of all registered students.
- **Search student by ID**: Quickly retrieve a specific student's details.
- **Update student details**: Modify a student's Name, Age, and Mark dynamically.
- **Delete student**: Remove a student record from the system.
- **Calculate average**: Computes and displays the average marks of all students.
- **Robust Validation**: Includes proper exception handling for invalid user inputs (e.g., entering letters where numbers are expected).

## C# Concepts Demonstrated
| Concept | Where you'll find it |
|---------|----------------------|
| **Classes & Objects** | `Student` class model |
| **Encapsulation** | `Student` properties (`Id`, `Name`, `Age`, `Mark`) |
| **Constructors** | Creating `Student` objects |
| **Methods** | `AddStudent()`, `DeleteStudent()`, etc. in `StudentService` |
| **List<T>** | Storing the collection of students in memory |
| **if/else & switch** | Menu navigation and input validation in `Program.cs` |
| **Loops** | `while` loop for the menu, `foreach` to iterate over students |
| **Exception Handling** | `try/catch` blocks to prevent crashes on bad input |
| **LINQ** | `.FirstOrDefault()` for searching and `.Average()` for calculations |

## Project Structure
```text
StudentManagementSystem/
│
├── Program.cs         # Contains the main entry point and the interactive menu
├── Student.cs         # Defines the Student object
└── StudentService.cs  # Manages operations (add, edit, view, delete, calculate)
```

## How to Run
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
2. Clone this repository:
   ```bash
   git clone https://github.com/AiswaryaManoj06/StudentTrack-Student-Management-System.git
   ```
3. Navigate to the project directory:
   ```bash
   cd StudentTrack-Student-Management-System
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
