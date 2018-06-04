using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = appendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
        static string appendAndDelete(string s, string t, int k)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(s);
            for (int i=0;i<k;i++)
            {

            }
            return null;
        }
    }
}
