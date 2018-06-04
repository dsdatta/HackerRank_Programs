using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program27
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(i!=j)
                    {
                      if((ar[i]+ar[j])%k==0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count/2;



            //Dictionary<int, int> hash = new Dictionary<int, int>();
            //for(int i = 0; i<ar.Length;i++)
            //{
            //    if (hash.ContainsKey(ar[i]))
            //    {
            //        hash[ar[i]] += 1;
            //    }
            //    else
            //    {
            //        hash.Add(ar[i], 1);
            //    }
            //}
            //int count = 0;

            //for(int j=0;j<hash.Count;j++)
            //{
            //    int sum = hash.FirstOrDefault(o => o.Key == ar[j]).Key;
            //    int sum2= hash.FirstOrDefault(o => o.Key == ar[j + 1]).Key;
            //    if (sum + sum2%3==0)
            //    {
            //        count = hash.FirstOrDefault(f => f.Key == ar[j]).Key;
                   
            //    }
            //}


            //return 0;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
