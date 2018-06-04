using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            List<Int32> listMax = new List<Int32>();
            List<Int32> listMin = new List<Int32>();
            //List<int> list = new List<int>();
           // list.AddRange(arr);
            listMin.AddRange(arr);
            listMin.Sort();
            listMin.Remove(listMin[0]);

            listMax.AddRange(arr);
            listMax.Sort();
            listMax.Remove(listMax[listMax.Count - 1]);
            Int64 j = 0;
            foreach (Int32 i in listMin)
            {
                j = j + i;

            }
            Int32 z = 0;
            foreach (Int32 k in listMax)
            {
                 z = z+ k;

            }
            Console.Write(z +" "+ j);
            Console.Read();

        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
      ;
            miniMaxSum(arr);
        }
    }
}
