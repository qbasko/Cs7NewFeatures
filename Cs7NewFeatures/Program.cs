using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {

            TestMethod(out int a, out int b);
            Console.WriteLine($"a = {a} \t b = {b} ");
        }


        static void TestMethod(out int a, out int b)
        {
            a = 1;
            b = 1;
        }
    }
}
