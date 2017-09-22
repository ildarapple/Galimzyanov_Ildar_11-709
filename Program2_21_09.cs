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
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                if (y > z) Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2}", x, y, z));
                else Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2}", x, y, z));
            }
            if (y > x && y > z)
            {
                if (x > z) Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2}", y, x, z));
                else Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2}", y, z, x));
            }
            if (z > y && z > x)
            {
                if (x > y) Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2} {" z, x, y, "}"));
                else Console.WriteLine(string.Format(" Ваш ответ: {0} {1} {2}", z, y, x));
            }
            Console.ReadLine();
        }
    }
}
