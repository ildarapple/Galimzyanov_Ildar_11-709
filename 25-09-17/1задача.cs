using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[]{ 10, 2, 5, 2 };
            int s = 0;
            for (int i = 0; i < mas.Length; i++) s += mas[i];
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
