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
            int[] mas = new int[] { 2, 2, 5, 2 };
            int s = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (s < mas[i])
                    s = mas[i];
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
