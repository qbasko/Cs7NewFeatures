using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class Ref
    {
        public void Run()
        {
            int[] tab = { 22, -10, 22 };
            ref int minus_ten = ref smth(tab);
            Console.WriteLine(tab[1] == -10);

            minus_ten = 22;
            Console.WriteLine(tab[1] == 22);
        }

        public ref int smth(int[] tab)
        {
            return ref tab[1];
        }

    }
}
