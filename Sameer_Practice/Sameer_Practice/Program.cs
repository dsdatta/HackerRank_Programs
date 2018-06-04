using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sameer_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
                        int y = 6;
                        List<int> x;
                        List<int> z = new List<int>();
                        x = new List<int>() { 22, 32, 34, 48, 50, 68, 79, 8, 9, 10, 11, 12, 13,20,99 };

                        for (int n = 0; n < x.Count; n++)
                        {

                            if (n < y)
                            {

                                z.Add(x[n]);
                  

                             }
                            else if (n == y)
                            {
                              z.ForEach(Console.WriteLine);
                    Console.ReadKey();
                    z.Clear();
                              y = y * 2;
                              z.Add(x[n]);                  
                }

                if (n == x.Count - 1)
                {
                    z.ForEach(Console.WriteLine);
                    Console.ReadKey();
                }   

            }
            

        }                  

    }
}
