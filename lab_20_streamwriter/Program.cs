using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab_20_streamwriter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // OVERWRITE MODE
            using (var writer = new StreamWriter("data.txt"))
            {
                for(int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Data line{i}");
                }
            }

            // APPEND MODE
            using (var writer = new StreamWriter("data.txt", true))
            {
                writer.WriteLine("add some more");
            }

            // SET ENCODING (UTF8 BY DEFAULT)
            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8))
            {
                writer.WriteLine("add some more");
            }

            // FOR HUGE FILES: SPEED UP PROCESS BY ALTERING BUFFER SIZE WHICH IS THE UNIT OF DATA TRANSFER
            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8, 10000)) //BUFFER SIZE IS 10000 HERE
            {
                writer.WriteLine("lots and lots and lots of... data");
            }
        }
    }
}
