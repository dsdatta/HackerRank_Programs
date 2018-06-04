using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project21
{
    class Program
    {
        static void staircase(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y < n; y++)
                {

                    if (y >= n - x)
                    {
                        Console.Write(" ");
                    }
                else
                   {
                        Console.Write("#");
                    }


                }
       
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
