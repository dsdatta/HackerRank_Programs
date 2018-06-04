using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int n = x1;
            int m = x2;
            string output="";
            if(v1>v2 && x1<=x2 || v2>v1 && x2<=x1)
            {
                for(int x=0;x<=n;x++)
                {
                    n = n + v1;
                    m = m + v2;
                    if(m==n)
                    {
                        output= "YES";
                        break;
                    }
                    else
                    {
                        output = "NO";
                    }
                }
            }
            else
            {
                output = "NO";
            }
          
            return output;

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
