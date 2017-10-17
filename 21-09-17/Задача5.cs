using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i<=1000000; i++)
            {
                int s = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) s += 1;
                }
                if (s == 2) Console.WriteLine(i);
            }
        }
    }
}
