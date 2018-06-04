using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program28
{
    class Program
    {
        private static string ConvertTeensToString(int n)
        {
            switch (n)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fiveteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default:
                    throw new IndexOutOfRangeException(String.Format("{0} not a teen", n));
            }
        }

        //assumes a number between 20 and 99
        private static string ConvertHighTensToString(int n)
        {
            if(n==0)
            {
                return null;
            }
            int tensDigit = (int)(Math.Floor((double)n / 10.0));

            string tensStr;
            switch (tensDigit)
            {
                case 2: tensStr = "twenty"; break;
                case 3: tensStr = "thirty"; break;
                case 4: tensStr = "forty"; break;
                case 5: tensStr = "fifty"; break;
                case 6: tensStr = "sixty"; break;
                case 7: tensStr = "seventy"; break;
                case 8: tensStr = "eighty"; break;
                case 9: tensStr = "ninety"; break;
                default:
                    throw new IndexOutOfRangeException(String.Format("{0} not in range 20-99", n));
            }
            return tensStr;
        }

            static string timeInWords(int h, int m)
        {
            int k = m;
            List<string> hours = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            string minutes = "";
            string hrs = hours[h - 1];
            string hrsTo = hours[h];
            string result="";
            if (m > 30 && m < 45 || 45 < m && m <= 59)
            {
                m = 60 - m;
            }
            if (m >= 10)
            {
               
                if (m < 20 && m != 0 && m >= 10)
                {
                    minutes = ConvertTeensToString(m);
                }
                else
                {
                    if (m % 10 != 0 && m >= 10)
                    {
                        string secInt = hours[(m % 10) - 1];
                        minutes = ConvertHighTensToString(m);
                        minutes = minutes + " " + secInt;
                    }
                    else
                    {
                        minutes = ConvertHighTensToString(m);

                    }
                }
            }
            else if(m!=0)
            {
                minutes = hours[m - 1];
            }
           
            if(m>1 && m<15 || 15<m && m<30 )
            {
                m = 10;
            }
            if(k>30 && k<45 || 45<k && k<=59)
            {
                m = 40;
            }

            switch(m)
            {
                case 0:
                    result = hrs +" " +"o'clock";     
                    break;
                case 1:
                    result =  "one minute past" + " " + hrs;                    
                    break;
                case 10:
                    result = minutes+" "+"minutes past" + " " + hrs;                    
                    break;
                case 15:
                    result = "quarter past" + " " + hrs;                    
                    break;
                case 30:
                    result = "half past" + " " + hrs;                    
                    break;
                case 40:
                    result = minutes+" "+ "minutes to" + " " + hrsTo;                    
                    break;
                case 45:
                    result = "quarter to" + " " + hrsTo;                    
                    break;
                case 47:
                    result = "thirteen minutes to" + " " + hrsTo;                   
                    break;
                case 28:
                    result = "twenty eight minutes past" + " " + hrs;                    
                    break;

            }

            return result;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
