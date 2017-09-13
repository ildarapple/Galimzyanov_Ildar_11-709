using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i < n; i++) if (i % x == 0 || i % y == 0) s = s + 1;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
