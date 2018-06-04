using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');
           // string[] extramagazine = new string[m];
            Dictionary<string, int> hashmagazine = new Dictionary<string, int>();
            Dictionary<string, int> hashransome = new Dictionary<string, int>();
            List<string> extramagazine = new List<string>();
           // Dictionary<string, int> extramagazine = new Dictionary<string, int>();

            int count = 0;
            for (int i=0;i<m;i++)
            {
                if(!hashmagazine.ContainsKey(magazine[i]))
                {
                    hashmagazine.Add(magazine[i], 1);
                }
                else
                {
                    hashmagazine[magazine[i]] +=1;
                    //extramagazine[i]= magazine[i];
                }
            }
           
            for (int j=0;j<n;j++)
            {
                //if(hashmagazine.ContainsKey(ransom[j])&&!hashransome.ContainsKey(ransom[j]))
                if (hashmagazine.ContainsKey(ransom[j]) && hashmagazine[ransom[j]] > 1)
                {
                    hashmagazine[ransom[j]] -= 1;
                   // hashransome.Add(ransom[j],j);
                   
                    }
                // else if(extramagazine.Contains(ransom[j]))
                 else if(hashmagazine.ContainsKey(ransom[j]) && hashmagazine[ransom[j]]==1)
                {
                    // extramagazine.Remove(ransom[j]);
                    hashmagazine.Remove(ransom[j]);
                   
                }
                else
                {
                    count++;
                }
                
            }
            if(count>=1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            
            Console.ReadKey();
           
         
        }
    }
}
