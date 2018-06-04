using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int n = 3;
            int[][] arr = new int[6][];
            int[][] arr1 = new int[3][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            for (int i = 0; i < 6; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1.SetValue(arr[i][j],i j); 
                }
                if(j==n-1)
                {
                    j = n;
                    n = n * 2;
                  
                }
            }

        }
    }
}
