using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = caesarCipher(s, k);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static string caesarCipher(string s, int k)
        {
            StringBuilder strbuild = new StringBuilder();
            strbuild.Append(s);         
            for(int i= 0;i<strbuild.Length;i++)
            {
                if(Regex.IsMatch(strbuild[i].ToString(), "^[a-zA-Z]+$"))
                {
                    char c = strbuild[i];
                    char y;
                    
                         y = (char)(Convert.ToUInt16(c) + k);
                    if(y=='|')
                    {
                      
                        for(int j=0)
                    }
                    strbuild.Remove(i, 1);
                    strbuild.Insert(i, y);
                   // strbuild.Replace(([i]c.ToString()), y.ToString());
                }
            }
            return strbuild.ToString();
        }
    }
}
