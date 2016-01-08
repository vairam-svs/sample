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
            Console.WriteLine("Always start work from dev/other branch/not directly on master");
            Console.WriteLine("Need creation of contribution document - excludes definition for release management complexity - FIFO code change to deploy methodology");
            PrintSum(3, 4);
            Console.Read();
        }
        private static void PrintSum(int a, int b)
        {
            Console.WriteLine("sum of a + b = {0}", a + b);
            
        }
    }
}
