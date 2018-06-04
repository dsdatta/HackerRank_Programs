using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    class Program
    {
        static void Main(string[] args)
        {

            string words = "";
            string Name = "I Love RCB";
            foreach (char c in Name)
            {
                if (!char.IsWhiteSpace(c))
                {
                    words = words + c;
                }
                else
                {
                    Console.WriteLine(words);
                    words = "";
                }

            }
            Console.WriteLine(words);
            Console.Read();



            //List<string> duplicates = new List<string>();
            //var teams = new string[] { "RCB", "MI", "RCB", "KKR" };
            //foreach (var b in teams)
            //{
            //    if (!duplicates.Contains(b))
            //    {
            //        duplicates.Add(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //        Console.Read();
            //    }
            //}

        }
    }
}
