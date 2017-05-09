using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class Tuples
    {
        public void Run()
        {
            var tupleType1 = GetValues1();
            Console.WriteLine($"{tupleType1.Item1}, {tupleType1.Item2}, {tupleType1.Item3}");

            var tupleType2 = GetValues2();
            Console.WriteLine($"{tupleType2.Val1}, {tupleType2.Val2}, {tupleType2.Val3}");
            //it works as well
            Console.WriteLine($"{tupleType2.Item1}, {tupleType2.Item2}, {tupleType2.Item3}");

            //Deconstruction

            (string val1, var val2, var val3) = GetValues2();
            Console.WriteLine($"{val1}, {val2}, {val3}");

            //or 

            var (a, b, c) = GetValues1();
            Console.WriteLine($"{a}, {b}, {c}");

            

            string x, y, z;
            (x, y, z) = GetValues1();
            Console.WriteLine($"{x}, {y}, {z}");


        }

        (string, string, string) GetValues1() // tuple return type
        {
            return ("TestVal1", "TestVal2", "TestVal3"); // tuple literal
        }

        (string Val1, string Val2, string Val3) GetValues2() // tuple return type
        {
            return (Val1: "TestVal1", Val2: "TestVal2", Val3: "TestVal3"); // tuple literal
        }
    }
}
