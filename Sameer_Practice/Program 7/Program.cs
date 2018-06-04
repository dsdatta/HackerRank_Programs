using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            //int[] arr_new = new int[n];
            //int count = 0;
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    arr_new[count] = arr[i];
            //    count++;
            //}
              Console.WriteLine("{0}", string.Join(" ", arr));
            
          //  Console.WriteLine(arr.Reverse());
            //Console.WriteLine(arr_new);
            Console.ReadKey();
        }
    }
}
