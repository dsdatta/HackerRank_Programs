using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            float p = 0, n = 0, z = 0;
            int x = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    p++;
                }
                else if (arr[i] < 0)
                {
                    n++;
                }
                else if (arr[i] == 0)
                {
                    z++;
                }
            }
            
            Console.WriteLine(p / x);
            Console.ReadLine();
            Console.WriteLine(n / x);
            Console.ReadLine();
            Console.WriteLine(z / x);
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr);
        }
    }
}
