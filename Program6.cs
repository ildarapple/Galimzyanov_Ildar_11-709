using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());//а прямой
            int y1 = int.Parse(Console.ReadLine());//a прямой
            int x2 = int.Parse(Console.ReadLine());//b прямой
            int y2 = int.Parse(Console.ReadLine());//b прямой
            int x3 = int.Parse(Console.ReadLine());//точка 
            int y3 = int.Parse(Console.ReadLine());//точка
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double p = a + b + c;
            p = p / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double h = (2 * s) / a;
            Console.WriteLine(h);
            Console.ReadLine();
        }
    }
}
