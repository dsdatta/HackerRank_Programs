using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program15
{
    class Program
    {
        static int camelcase(string s)
        {
            StringBuilder builder = new StringBuilder();
            foreach(char c in s)
            {
                if(char.IsUpper(c))
                {
                    builder.Append(' ');
                }
            }
            int count = 0;
          //  string[] arr = Regex.Split(s, @"[A-Z]");
           return  count = builder.Length+1;

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine(result);
        }
    }
}
