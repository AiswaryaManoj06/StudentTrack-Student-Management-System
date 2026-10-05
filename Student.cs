using System;

namespace StudentTrack
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Mark { get; set; }

        public Student(int id, string name, int age, double mark)
        {
            Id = id;
            Name = name;
            Age = age;
            Mark = mark;
        }
    }
}
