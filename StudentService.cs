using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentTrack
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        public void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Mark: {student.Mark}");
            }
        }

        public Student SearchStudent(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStudent(int id, string name, int age, double mark)
        {
            var student = SearchStudent(id);
            if (student != null)
            {
                student.Name = name;
                student.Age = age;
                student.Mark = mark;
                Console.WriteLine("Student updated successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DeleteStudent(int id)
        {
            var student = SearchStudent(id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void CalculateAverage()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available to calculate average.");
                return;
            }

            double average = students.Average(s => s.Mark);
            Console.WriteLine($"Average marks of all students: {average:F2}");
        }
    }
}
