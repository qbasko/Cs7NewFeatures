using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class LiteralImprovements
    {
        public void Run()
        {
            var a = 123_456_789; //int
            Console.WriteLine(a); // output: 123456789

            var b = 0b1010_1010;
            Console.WriteLine(b); // output: 170

        }

    }
}
