using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{

    class Complex
    {
        int a, b;
        public Complex(int a, int b)//Конструктор, который инициализирует данные
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()//функция, которая выводит данные в виде строки
        {
            return this.a + "/" + this.b;// funkciya dlya peregruzki
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.a * b.b + b.a * a.b, a.b * b.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 3);
            Complex b = new Complex(2, 2);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}