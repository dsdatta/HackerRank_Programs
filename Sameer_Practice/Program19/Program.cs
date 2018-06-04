using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19
{
    class Program
    {
        static void solve(int[] arr, int money)
        {

            List<int> menu = new List<int>();
            menu = arr.ToList();
            menu.Sort();
            List<int> sub = new List<int>();
           
            int m = money / 2;
            for(int j= 0; j<menu.Count;j++)
            {
                if (menu[j] < money)
                {
                    sub.Add(menu[j]);
                }
            }
            int max = sub.Count-1;
            for (int i = 0; i < sub.Count; i++)
            {
                for (int k = sub.Count-1; k > 0; k--)
                {
                    if (sub[i] + sub[k] == money && i != k)
                    {
                        int first = (Array.IndexOf(arr, sub[i])) + 1;
                        int last = (Array.LastIndexOf(arr, sub[k])) + 1;
                        Console.WriteLine(first + " " + last);
                        Console.ReadKey();
                        break;
                    }
                    //max = max - 1;
                    
                }
            }

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int money = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');

                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                solve(arr, money);
            }
        }
    }
}
