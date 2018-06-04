using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int preValue=0;

            List<int> result = new List<int>();
            List<int> numb = new List<int> {1,3,5,7,5,2,3,1,1,8,1,8};
            for(int i = 0;i<numb.Count;i++)
            {
                int count = 0;
                for (int j =0; j<numb.Count;j++)

                {
                    if(numb[i]==numb[j] && numb[i]!=preValue )
                    {
                        count++;                                                
                    }                   
                 
                }
                if(count==2)
                {
                    preValue = numb[i];
                    result.Add(numb[i]);
                    
                }
               
                
            }

            result.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
