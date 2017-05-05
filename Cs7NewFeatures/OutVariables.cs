using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class OutVariables
    {
        public void Run()
        {
            Console.WriteLine(nameof(Cs6Style));
            Cs6Style();
            Console.WriteLine(nameof(Cs7Style));
            Cs7Style();
        }

        private void Cs6Style()
        {
            int a, b;
            TestMethod(out a, out b);
            Console.WriteLine($"a = {a} \t b = {b} ");
        }

        private void Cs7Style()
        {
            TestMethod(out int a, out int b);
            TestMethod(out var c, out var d);
            TestMethod(out _, out _); //I don't care about out variables

            Console.WriteLine($"a = {a} \t b = {b} ");
            Console.WriteLine($"c = {c} \t d = {d} ");
        }


        private void TestMethod(out int a, out int b)
        {
            a = 11;
            b = 22;
        }
    }
}
