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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ref int storageLocation = ref Find(array);
            Console.WriteLine(array[1] == 2); //true

            storageLocation = 11;
            Console.WriteLine(array[1] == 11); //true
            Console.WriteLine(array[1]); // 11
        }

        public ref int Find(int[] tab)
        {
            return ref tab[1];
        }

    }
}
