using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            a = a % 10 * 100 + a / 10 % 10 * 10 + a / 100;
            Console.Write(a);
            Console.ReadLine();
        }
    }
}
