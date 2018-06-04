using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
         
            List<int> indexList = new List<int>();
            List<int> FinalList = new List<int>();
            List<char> alphabets = new List<char> { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
           

            for(int j=0; j< word.Length; j++)
            {              
                int index = alphabets.FindIndex(s => s.Equals(word[j]));
                indexList.Add(index);
            }

            for(int k=0; k< indexList.Count;k++)
            {
                FinalList.Add(h[indexList[k]]);

            }
            FinalList.Sort();
            int highestValue = FinalList[FinalList.Count - 1];
            int result = highestValue * word.Length*1;

            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
