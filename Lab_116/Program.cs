using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_116
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                try
                {
                    throw new Exception("\nfix the error\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally { }

            }
            catch (Exception e)
            {
                Console.WriteLine("\they throw exception that has been caught at an upper level\t");
            }
            finally
            {
                Console.WriteLine("\nAll done\n");
            }
        }
    

    } // CLASS PROGRAM END
} // NAMESPACE END
