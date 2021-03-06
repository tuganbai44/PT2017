﻿using System;
using System.IO;
namespace Student
{
    class Lab2_3
    {
        static bool check(int x)  //checks int 
        {
            if (x == 1)
                return false;
            for (int i = 2; i * i <= x; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void MaxMin()
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\Documents\Visual Studio 2015\PT2017\Lab2_3\Lab2_3\input.txt"); //read data
            StreamWriter sw = new StreamWriter(@"C:\Users\user\Documents\Visual Studio 2015\PT2017\Lab2_3\Lab2_3\output.txt"); //write result
            string[] arr = sr.ReadLine().Split(); // writes data to string array
            int x = 999999;
            foreach (string s in arr)
            {
                int p = int.Parse(s);  // changes from string to integers
                if (p < x && check(p))
                    x = p;
            }
            sw.WriteLine(x);
            sw.Close();
            sr.Close();
        }
        static void Main(string[] args)
        {
            MaxMin();
        }
    }
}