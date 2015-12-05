namespace _01.CustomLinqExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            var list = new List<int> { 1, 2, 30, 4, 5, 6 };
            list
                .WhereNot(e => e % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine); // will return 1, 5

            Console.WriteLine(list.Maximum(i => i)); // will return 30

            var students = new List<Student>
            {
                new Student {Name = "Pesho", Age = 20},
                new Student {Name = "Gosho", Age = 15},
                new Student {Name = "Mariika", Age = 11},
            };

            Console.WriteLine(students.Maximum(s => s.Age)); // will return 20
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}