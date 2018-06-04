using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        static int factorial(int n)
        {
            float  k = Convert.ToUInt64(n);
            float count = 1;
            for (float j = Convert.ToUInt64(n); j > 1; j--)
            {
                k = k*(j - count);
               // count += 1;

            }
            Console.Write(k);
            Console.ReadKey();
            return n;
         
        }
    }
}
