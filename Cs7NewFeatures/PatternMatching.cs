using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs7NewFeatures
{
    public class PatternMatching
    {
        class SampleClass
        {
            public int Id { get; set; }
        }


        public void Run()
        {
            Cs7Is();
            Cs7Case();
        }

        private void Cs7Is()
        {
            object c1 = new SampleClass() { Id = 1 };
            if (c1 is SampleClass c)
            {
                Console.WriteLine(c.Id);
            }

        }

        private void Cs7Case()
        {
            object c1 = new SampleClass() { Id = 2 };

            switch (c1)
            {
                case SampleClass sc when sc.Id % 2 == 0:
                    Console.WriteLine("Id % 2 == 0");
                    break;

                case SampleClass sc:
                    Console.WriteLine(sc.Id);
                    break;

                case null:
                    Console.WriteLine("Obj is null");
                    break;

                default:
                    Console.WriteLine("Nothing to do");
                    break;


            }


        }
    }
}
