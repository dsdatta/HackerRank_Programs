using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord(Console.ReadLine()));
            Console.ReadKey();

        }
        public static string LongestWord(string sen)
        {
            
            string Prev = "";
            String[] sub = sen.Split(' ');
            foreach (var lar in sub)
            {
                if (lar.Length > Prev.Length)
                    Prev = lar;
            }
            return Prev;

        }
    }
}
