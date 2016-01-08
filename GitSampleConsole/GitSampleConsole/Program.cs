using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("getting ready to make change, change not complete");
            PrintSum(3, 4);
            Console.Read();
        }
        private static void PrintSum(int a, int b)
        {
            Console.WriteLine("sum of a + b = {0}", a + b);
            
        }
    }
}
