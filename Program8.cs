using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());//а прямой
            int y1 = Convert.ToInt32(Console.ReadLine());//a прямой
            int x2 = Convert.ToInt32(Console.ReadLine());//b прямой
            int y2 = Convert.ToInt32(Console.ReadLine());//b прямой
            int x3 = Convert.ToInt32(Console.ReadLine());//точка 
            int y3 = Convert.ToInt32(Console.ReadLine());//точка
            double L = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double p = a + b + c;
            p = p / 2;
            double s = Math.Sqrt(p * (p - L) * (p - b) * (p - c));
            double h = (2 * s) / L;
            Console.WriteLine(h);
            Console.ReadLine();
        }
    }
}
