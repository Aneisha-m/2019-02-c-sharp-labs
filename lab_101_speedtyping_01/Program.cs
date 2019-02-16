using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

//Game Pseudocode:
//stopwatch - timer - date.now 10secs - try each
//alert user at the end of 10 secs
//Mode 1: Random letters type : throw exceptions if numbers or punctuation typed  
// Mode 2: ordered letters typed :  while loops set to true as long as time is <= set time in seconds.
//output chars typed for the duration of challenge 
//throw exception if wrong char typed eg. numbers spaces or punctuation
//threading.sleep to delay stop watch 

namespace lab_101_speedtyping_01
{
    class Program
    {
        static string alpha = "abcdefghijklmnopqrstuvwxyz", letters = "";

        static void Main(string[] args)
        {
            Rand();
        }

        public static void Rand()
        {
            int total = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("\nstart typing...");
            while (stopWatch.ElapsedMilliseconds < 10000)
            {
                letters += Console.ReadKey().KeyChar;
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (alpha.Contains(letters[i]))
                {
                    total++;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("\n your total is" + total.ToString());
            Console.WriteLine("\nEnter to escape game\n");
            Console.ReadLine();
        }
    }
}
