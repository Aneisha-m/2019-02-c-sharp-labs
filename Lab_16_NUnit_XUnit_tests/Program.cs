using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_NUnit_XUnit_tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    } // PROGRAM CLASS END
    
    public class TestMeNow
    {
        public double TestThiMethodWorks(double x, double y, int p)
        {
            Console.WriteLine($"Here is some data {x},{y},{p}");
            //2,3,3, ==> (2*3) = 6 abd raise to power 3 i.e. 36
            return Math.Pow((x*y),p);
        }
    }
}
