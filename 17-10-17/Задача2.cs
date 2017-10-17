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
            int[] array = {1, 2, 3, 4, 5};
            int min = array[0];
            int max = array[0];
            int imin = 0;
            int imax = 0;
            for (int i = 0; i < 5; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }

                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
            }
            int smax = 0;
            int smin = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i != imin)
                {
                    smax += array[i];
                }

                if (i != imax)
                {
                    smin += array[i];
                }
            }
            Console.WriteLine("max = " + smax);
            Console.WriteLine("min = " + smin);
            Console.ReadLine();
        }
    }
}
