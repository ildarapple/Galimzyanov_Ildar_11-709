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
            int[] mas = new int[] { 10, 2, 5, 2 };
            int sp = 0;
            int sm = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                    sm += mas[i];
                else sp += mas[i];
            }
            if (sp > sm) Console.WriteLine("Положительных больше");
            else Console.WriteLine("Отрицательных больше");
            Console.ReadLine();
        }
    }
}
