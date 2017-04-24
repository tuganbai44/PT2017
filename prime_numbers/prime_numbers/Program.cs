using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace prime_numbers
{
    class Program
    {
        static bool isPrime(int n)//prime ба prime емес па тексереді
        {
            if (n == 1) return false;
            if (n == 2) return true;
            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(string[] args)//Обработка вводных данных
        {
            string[] str = Console.ReadLine().Split(); //считывает числа, сохраняет в массив чисел
            int[] a = new int [str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                a[i] = int.Parse(str[i]);
                if (isPrime(a[i]))
                {
                    Console.WriteLine(a[i]);
                } 
            }
            Console.ReadKey();

        }
    }
}
