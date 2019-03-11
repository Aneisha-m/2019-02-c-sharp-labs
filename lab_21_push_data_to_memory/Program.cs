using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_21_push_data_to_memory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var memorystream = new MemoryStream())
            {
                byte[] buffer = new byte[100];
                //memorystream.Write(buffer); IGNORE THIS CODE - WAS NOT COMPLETED 

                memorystream.Flush(); // SEND DATA TO MEMORY

                memorystream.Position = 0; // RESET POINTER TO START WHICH IS 0, BUT CAN MOVE TO ANY POINTER OTHER THAN START

                // READ DATA
                var reader = new StreamReader(memorystream);
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
