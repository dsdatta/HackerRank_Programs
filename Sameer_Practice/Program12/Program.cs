using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int count = 0;
            int prevcount = 0;
            int prev=0;
            int count1 = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] binary = new int[n];
            for (i = 0; n > 0; i++)
            {
                binary[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                
                   
                
                if(binary[i] == 1)
                {
                    count++;
                    if(binary[i] == prev /*&& count < prevcount*/)
                    {
                        prevcount = count;
                        if(prevcount>count1)
                        {
                            count1 = prevcount;
                            
                        }
                    }
                   
                }
                else
                {
                    count = 0;
                }
                
                prev = binary[i];

            }
          //count=  count + 1;
            if (count1 > prevcount)
            {
             
                Console.WriteLine(count1);
            }
            else if(prevcount>count)
            {
                Console.WriteLine(prevcount);
            }
            else
            {
                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
