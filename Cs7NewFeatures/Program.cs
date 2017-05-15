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
            Console.WriteLine(nameof(OutVariables));
            var outVariables = new OutVariables();
            outVariables.Run();

            Console.WriteLine(nameof(PatternMatching));
            var patternMatching = new PatternMatching();
            patternMatching.Run();

            Console.WriteLine(nameof(Tuples));
            var tuples = new Tuples();
            tuples.Run();

            Console.WriteLine(nameof(Ref));
            var @ref = new Ref();
            @ref.Run();

            Console.WriteLine(nameof(LocalFunctions));
            var localFunctions = new LocalFunctions();
            localFunctions.Run();

            Console.WriteLine(nameof(LiteralImprovements));
            var literalImprovements = new LiteralImprovements();
            literalImprovements.Run();

            Console.Read();
        }
    }
}
