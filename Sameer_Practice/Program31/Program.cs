using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program31
{
    class Program
    {
        static int solve(int[] s, int d, int m)
        {
            int t = 0;
            int r = 0;
            int f = 0;           
            int count = 0;
            
            for(int i= 0;i<s.Length;i++)
            {
                t = i;
                if(t<m)
                {
                    f = r;
                    r = r + s[t];
                    if(r==d /*&& (t==0 ||f!=0)*/)
                    {
                        count++;  
                    }
                   
                }
                else
                {
                    r = s[t-1];
                    m = m +1;
                    i = i - 1;
                    continue;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp))
            ;
            string[] dm = Console.ReadLine().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = solve(s, d, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
