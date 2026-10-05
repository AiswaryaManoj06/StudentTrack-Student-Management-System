using System;
using StudentTrack;

namespace StudentTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Calculate Average");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentPrompt(service);
                        break;
                    case "2":
                        service.ViewStudents();
                        break;
                    case "3":
                        SearchStudentPrompt(service);
                        break;
                    case "4":
                        UpdateStudentPrompt(service);
                        break;
                    case "5":
                        DeleteStudentPrompt(service);
                        break;
                    case "6":
                        service.CalculateAverage();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }

        static void AddStudentPrompt(StudentService service)
        {
            try
            {
                Console.Write("Enter Student ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Student Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Student Mark: ");
                double mark = double.Parse(Console.ReadLine());

                Student newStudent = new Student(id, name, age, mark);
                service.AddStudent(newStudent);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter appropriate values for ID (number), Age (number), and Mark (number).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void SearchStudentPrompt(StudentService service)
        {
            try
            {
                Console.Write("Enter Student ID to search: ");
                int id = int.Parse(Console.ReadLine());
                
                var student = service.SearchStudent(id);
                if (student != null)
                {
                    Console.WriteLine($"Found - ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Mark: {student.Mark}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
        }

        static void UpdateStudentPrompt(StudentService service)
        {
            try
            {
                Console.Write("Enter Student ID to update: ");
                int id = int.Parse(Console.ReadLine());

                var student = service.SearchStudent(id);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.Write($"Enter new Name (current: {student.Name}): ");
                string name = Console.ReadLine();

                Console.Write($"Enter new Age (current: {student.Age}): ");
                int age = int.Parse(Console.ReadLine());

                Console.Write($"Enter new Mark (current: {student.Mark}): ");
                double mark = double.Parse(Console.ReadLine());

                service.UpdateStudent(id, name, age, mark);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter appropriate values for Age (number) and Mark (number).");
            }
        }

        static void DeleteStudentPrompt(StudentService service)
        {
            try
            {
                Console.Write("Enter Student ID to delete: ");
                int id = int.Parse(Console.ReadLine());
                service.DeleteStudent(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
        }
    }
}
