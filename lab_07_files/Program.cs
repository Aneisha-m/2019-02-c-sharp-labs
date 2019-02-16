using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //file read as string
                string data01 = File.ReadAllText("file.txt");
            }
            //catch specific exceptions : HANDLING THE EXCEPTIONS
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Phill says make that file");
            }
            //always run regardless
            finally
            {
                Console.WriteLine("and make it quick");
            }
        }
    }
}
