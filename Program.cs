using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static bool check (int x)
        {
            for (int i = 2; i < x; ++i)
                if (x % i == 0)
                    return false;
            if (x == 1)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                int p = int.Parse(s);
                if (check(p))
                    Console.WriteLine(p);
            }
        }
    }
}
