using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

// GAME PSEUDOCODE : V2.0 OBJECTIVES
// KEEP STOPWATCH, TRY THREADING.SLEEP TO DELAY STOPWATCH START
// ADD STRICT MODE : ALPHA ORDERED
// ADD CONTROL FLOW FOR USER NAV / PROMPT
// OUTPUT SCORE 
// OPTIONAL : EXCEPTIONS FOR NUMBERS, SPACES, PUNCTUATION TYPED

namespace lab_101_speedtyping_02
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
            Console.WriteLine("\nYou are on RANDOM MODE : Start typing...");
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

        public static void Alpha()
        {
            string alph = "abcdefghijklmnopqrstuvwxyz", letters = "";
            int total = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("You are on STRICT MODE : Start typing... ");
            while (stopWatch.ElapsedMilliseconds < 10000)
            {
                letters += Console.ReadKey().KeyChar;

            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == alph[i % 26])
                {
                    total++;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("Your total is " + total.ToString());
            Console.WriteLine("\nEnter to escape game\n");
            Console.ReadLine();

        }

   
    } // CLASS PROGRAM END
} // NAMESPACE END
