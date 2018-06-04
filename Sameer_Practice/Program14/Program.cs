using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program14
{
    class Program
    {
        static string isValid(string email)
        { 
            string[] arr = email.Split('@');
            string res;
            int s = arr[0].Length;
            int j = Regex.Matches(arr[0], @"[a-z]").Count;
            if (arr[1]=="hogwarts.com" && s==j && j==5 )
            {
                res = "Yes";
            }
            else
            {
                res = "No";
            }
            return res;
         }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = isValid(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
