using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program30
{
    class Program
    {
        static string encryption(string s)
        {
            double sqroot = Math.Sqrt(s.Length);
            int one;
            if (sqroot % 1 >0)
            {
              one  = (int)sqroot+1;
            }
            else
            {
                 one = (int)sqroot;
            }
           
            string str = "";
            List<string> str1 = new List<string>();
            string result = "";
            for(int i=0;i<s.Length;i++)
            {
                 str =  str+ s[i];
                if(str.Length>=one)
                {
                    str1.Add(str);
                    str = "";
                }
                if(i==s.Length-1)
                {
                    str1.Add(str);

                }
            }
            int c = 0;
            int d = 0;
            for (int j = 0; j < str1.Count; j++)
            {
                string r = str1[j];
                if(str1[0].Length<c+1)
                {
                    break;
                }
                if(r.Length<c+1)
                {
                    result = result + " ";
                    j = -1;
                    c++;
                    continue;
                }
                result = result + r[c].ToString();

                if (j== str1.Count - 1)
                {
                    result = result + " ";
                    j = -1;
                    d++;
                    c++;
                }
            }
                //foreach(var r in str1)
                //     {
                //         result = result+r[c].ToString() ;
                //     }
                //StringBuilder str = new StringBuilder(s);
                //int ind = one;
                //for (int i=1;i<=one;i++)
                //{
                //    if (ind <= str.Length)
                //    {
                //        str.Insert(ind, str[ind]);
                //        str.Remove(ind,1);

                //    }

                //    if(i<=one-1)
                //    {
                //        str.Insert(ind, " ");
                //    }
                //    ind = (ind * 2) + 1;

                //}




                return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = encryption(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
