using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program29
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Ar1 = new int[] {12,9,7,10,1,1 };
            int[] Ar2 = new int[] { 2, 20, 18, 1 ,0,3};
            List<int> result = new List<int>();
            foreach(var numb in Ar1)
            {
                result.Add(numb);
            }
            foreach (var numb in Ar2)
            {
                result.Add(numb);
            }
            result.Sort();
            

            Console.WriteLine("{0},{1},{2}", result[0], result[1], result[2]);
            Console.ReadKey();
        }
    }
}
