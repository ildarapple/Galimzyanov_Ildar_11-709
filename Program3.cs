using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1 || a == 11 || a == 13 || a == 23) Console.WriteLine("30");
            else
            if (a == 2 || a == 10 || a == 14 || a == 22) Console.WriteLine("60");
            else
            if (a == 3 || a == 9 || a == 15 || a == 21) Console.WriteLine("90");
            else
            if (a == 4 || a == 8 || a == 16 || a == 20) Console.WriteLine("120");
            else
            if (a == 5 || a == 7 || a == 17 || a == 19) Console.WriteLine("150");
            else
            if (a == 6 || a == 18) Console.WriteLine("180");
            else
            if (a == 12 || a == 24) Console.WriteLine("0");
            if (a == 1 || a == 11) Console.WriteLine("30");
            Console.ReadLine();
        }
    }
}
