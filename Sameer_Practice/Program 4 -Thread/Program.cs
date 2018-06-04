using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program_4__Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating thread object to strat it
            Thread th = new Thread(ThreadC);
            Thread thb = new Thread(ThreadB);
            Console.WriteLine("Threads started :");
            // Start thread B
            thb.Start();
            th.Start();
            //Thread A executes 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread : A");
            }

            Console.WriteLine("Threads completed");
            Console.ReadKey();
        }
        public static void ThreadB()
        {
            //Executes thread B 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread : B");
            }
        }
    

        public static void ThreadC()
        {
            for (int i = 1;i<3;i++)
            {
                Console.WriteLine("Thread :C");
            }
        }
    }
}
