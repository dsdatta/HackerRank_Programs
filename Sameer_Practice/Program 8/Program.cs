using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int t=0;
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        t = a[0];
                    }

                  
                    if (i < n - 1)
                    {
                        a[i] = a[i + 1];
                    }

                    if (i == n - 1)
                    {
                        a[n - 1] = t;
                    }
                   
                }
            }
            Console.WriteLine("{0}", string.Join(" ", a));
            Console.ReadKey();
        }
    }
}
