using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class LocalFunctions
    {
        public void Run()
        {
            Console.WriteLine(Count());
        }

        private double Count()
        {
            double result = 0;
            result += Math.Pow(2, 8);

            return AddMore(result).current;

            (double current, double previous) AddMore(double d)
            {
                return (d+100, d);
            }
        }
    }
}
