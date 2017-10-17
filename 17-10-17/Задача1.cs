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
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int j = 0;
            bool yea = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (a[0] == b[i])
                {
                    int m = 0;
                    for (j = i; j < b.Length; j++)
                    {
                        if (b[j] == a[m])
                        {
                            m++;
                            if (m == a.Length)
                            {
                                yea = true;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(yea);
            Console.ReadLine();
        }
    }
}
