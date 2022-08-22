// See https://aka.ms/new-console-template for more information

using SampleCode.Arrays;
using SampleCode.Strings;

namespace SampleCode
{

    public class Test
    {
        private static void Main(string[] args)
        {
            ArrayRunner ar = new ArrayRunner();
            ar.RunArrayTests();

            StringRunner sr = new StringRunner();

            sr.RunStringTests();

            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55};
            var distinctAges = ages.Distinct().Average();
            Console.WriteLine(distinctAges);
        }
               

    }

}
