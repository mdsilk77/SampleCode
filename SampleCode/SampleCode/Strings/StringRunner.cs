using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Strings
{
    internal class StringRunner
    {
        public void RunStringTests()
        {
            char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };
            StringTests.StringReverse(s);

            int n = 2147483647;
            int i = StringTests.Reverse(n);
            Console.WriteLine(i + "\n");

            i = StringTests.FirstUniqueChar("aabb");
            Console.WriteLine($"The index of first unique character is: {i} \n");

            string sOne = "rat";
            string sTwo = "car";
            bool anagram = StringTests.IsAnagram(sOne, sTwo);
            Console.WriteLine($"Are {sOne} & {sTwo} anagrams: {anagram}");

            string sPalindrome = "ab_a";
            bool isPal = StringTests.IsPalindrome(sPalindrome);
            Console.WriteLine($"The string {sPalindrome} is a Palindrone: {isPal}");

            string sNum = "42";
            int num = StringTests.MyAtoi(sNum);
            Console.WriteLine($"The integer returned is {num}");
        }
    }
}
