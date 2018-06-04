using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            List<int> app = new List<int>();
            for(int x=0;x<apples.Length;x++)
            {
                int position = a + apples[x];
                if (position>=s && position<=t)
                {
                    app.Add(position);
                }
                
            }

            List<int> orr = new List<int>();
            for (int x = 0; x < oranges.Length; x++)
            {
                int positions = b + oranges[x];
                if (positions >= s && positions <= t)
                {
                    orr.Add(positions);
                }

            }

            Console.WriteLine(app.Count);
            Console.WriteLine(orr.Count);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
