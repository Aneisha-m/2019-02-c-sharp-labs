using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace lab_19_streaming
{
    class Program
    {
        static string line;
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            // MAIN METHOD IS THE Main Thread
            Console.WriteLine("Program Started");
            ReadData();
            Console.WriteLine("Sleeping finished so start working now");
            ReadDataAsync();
            Thread.Sleep(30);
            Console.WriteLine("Code is finished");
            Console.ReadLine();
        }

        static void ReadData()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Code has finished");
            Console.ReadLine();
        }

        static async void ReadDataAsync() //suffix every method thats asynchronous with Async
        {
            using (var reader = new StreamReader("data01.txt"))
            {
                while (true)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null)
                    {
                        break;
                    }
                    list.Add(line);
                    Console.WriteLine(line);
                }
            }
            Thread.Sleep(3000);
            Console.WriteLine("Work has finished reading text lines from data file");
        }
    }
}

