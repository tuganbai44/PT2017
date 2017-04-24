using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string name, surname;
        public int age;
        public Student (string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Marat", "Ospanov", 17);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
