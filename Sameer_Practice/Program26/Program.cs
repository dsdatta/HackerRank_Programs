using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int,int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (pairs.ContainsKey(ar[i]))
                {
                    pairs[ar[i]] += 1;
                }
                else
                {
                    pairs.Add(ar[i],1);
                }   
}
            int number;
            int result = 0;
            foreach (var hash in pairs)
            {
                int numb = hash.Value;
                if (numb % 2 == 0)
                {
                    number = numb / 2;
                }
                else
                {
                    number = (numb - 1) / 2;
                }
                result = number + result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
