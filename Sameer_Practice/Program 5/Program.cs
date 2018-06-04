using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            char[] arr1 = a.ToCharArray();
            char[] arr2 = b.ToCharArray();
            int count = 0;
            Dictionary<string, int> arr1hash = new Dictionary<string, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1hash.ContainsKey(arr1[i].ToString()))
                {
                    arr1hash.Add(arr1[i].ToString(), 1);
                }
                else
                {
                    arr1hash[arr1[i].ToString()] += 1;                    
                }
            }
            for (int j=0;j<arr2.Length;j++)
            {
                if(arr1hash.ContainsKey(arr2[j].ToString()) && arr1hash[arr2[j].ToString()]>1)
                {
                    arr1hash[arr2[j].ToString()] -= 1;
                }
                else if(arr1hash.ContainsKey(arr2[j].ToString()) && arr1hash[arr2[j].ToString()] == 1)
                {
                    arr1hash.Remove(arr2[j].ToString());
                }
                else
                {
                    count++;
                }
            }
            Dictionary<string, int>.ValueCollection values = arr1hash.Values;
            foreach (int val in values)
            {
                count = count + val;
            }
            Console.WriteLine(count);
               Console.ReadKey();

            //    List<string> list = new List<string>();
            //    var Prev = "";

            //    int count = 0;
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        for (int j = 0; j < arr2.Length; j++)
            //        {
            //            if (arr1[i] == arr2[j] && Prev!=arr1[i].ToString() && arr1[i]!=arr1[j])
            //            {


            //               if(!list.Contains(arr1[i].ToString()))
            //                {
            //                    list.Add(arr1[i].ToString());
            //                    count++;
            //                }

            //            }

            //        }                
            //    }
            //    int c = arr1.Length + arr2.Length;
            //    int result = c - (count*2);
            //Console.WriteLine(result);
            //    Console.ReadKey();
        }
    }
}
