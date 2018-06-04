using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> hash = new Dictionary<string, int>();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] hashname = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                hash.Add(input[0], Convert.ToInt32(input[1]));
            }
            for (int j = 0; j < n; j++)
            {
                string input1 = Console.ReadLine();
                hashname[j] = input1; 
            }



            foreach (var item in hashname)
            {
                if (hash.ContainsKey(item))
                {
                    int val = hash[item];
                    Console.WriteLine("{0}={1}", item, val);
                }
                else
                {
                    Console.WriteLine("Not found");
                }


            }
            Console.ReadKey();


        }

        
    }
}
