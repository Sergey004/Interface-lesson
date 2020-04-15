using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_lesson
{
    class Program
    {
                     
        static void Main(string[] args)
        {
            Student student1 = new Student() { Name = "Василий", Age = 20 };
            Student student2 = new Student() { Name = "Наталья", Age = 20 };

            Student[] students = new Student[] { student1, student2 };

            Array.Sort(students);
        }
        public struct Student: IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CompareTo(object obj)
            {
                Student student = (Student)obj;
                if (this.Age > student.Age) return 1;
                if (this.Age > student.Age) return -1;
                return 0;


            }
        }
    }
}
