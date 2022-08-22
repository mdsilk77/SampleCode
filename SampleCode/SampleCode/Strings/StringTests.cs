using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Strings
{
    internal class StringTests
    {
        public static int FirstUniqueChar(string s)
        {
            char[] chars = s.ToCharArray();
            int index = -1;

            for (int i = 0; i < chars.Length; i++)
            {
                if (index == -1)
                {
                    bool dupe = false;
                    int j = 0;
                    while (!dupe && j < chars.Length)
                    {
                        if (chars[i] == chars[j] && i != j)
                        {
                            dupe = true;
                        }
                        j++;
                    }

                    if (!dupe)
                    {
                        index = i;
                    }
                }
            }

            return index;
        }

        public static int Reverse(int x)
        {
            if (Math.Abs(Convert.ToInt64(x)) > int.MaxValue)
            {
                x = 0;
            }
            else
            {
                string y = new String(Math.Abs(x).ToString().Reverse().ToArray());

                if (Int64.Parse(y) > int.MaxValue || Int64.Parse(y) < int.MinValue)
                {
                    x = 0;
                }
                else if (x < 0)
                {
                    x = Int32.Parse(y);
                    x *= -1;
                }
                else
                {
                    x = Int32.Parse(y);
                }
            }

            return x;
        }

        public static void StringReverse(char[] s)
        {
            Array.Reverse(s);
            Console.WriteLine(s + "\n");

        }

        public static bool IsAnagram(string s, string t)
        {
            List<char> list1 = s.ToList();
            List<char> list2 = t.ToList();

            list1.Sort();
            list2.Sort();

            string sList1 = string.Join("", list1);
            string sList2 = string.Join("", list2);

            if (sList1 == sList2)
            {
                return true;
            }

            return false;
            //    List<char> list1 = s.ToList();
            //    List<char> list2 = t.ToList();

            //    if (list1.Count() != list2.Count())
            //    {
            //        return false;
            //    }

            //    List<char> processed = new List<char>();

            //    foreach(char c in list1)
            //    {
            //        if (!processed.Contains(c)) 
            //        {
            //            int charCount1 = list1.FindAll(x => x == c).Count();
            //            int charCount2 = list2.FindAll(x => x == c).Count();

            //            if (charCount1 != charCount2)
            //            {
            //                return false;
            //            }

            //            processed.Add(c);
            //        }

            //    }

            //    return true;
        }

        public static bool IsPalindrome(string s)
        {
            //string stripped = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToUpper();
            StringBuilder strippedSb = new StringBuilder();
            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') ||
                   (c >= 'A' && c <= 'Z') ||
                   (c >= '0' && c <= '9'))
                {
                    strippedSb.Append(c);
                }
            }

            string stripped = strippedSb.ToString();

            if (stripped.ToUpper() == String.Concat(stripped.Reverse()).ToUpper())
            {
                return true;
            }

            return false;
        }

        public static int MyAtoi(string s)
        {
            char[] sChar = s.Trim().ToCharArray();
            StringBuilder sb = new StringBuilder();
            int i = 0;

            
            while ((sChar[i] != '+' && sChar[i] != '-' || (sChar[i] < '0' && sChar[i] > '9')))
            {
                i++;
                if (i == sChar.Length - 1)
                {
                    break;
                }
            }

            if (i+1 < sChar.Length)
            {                                                   
                sb.Append(sChar[i]);
                i++;

                do
                {
                    if (Char.IsNumber(sChar[i]))
                    {
                        sb.Append(sChar[i]);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (i < sChar.Length);
            }

            return int.Parse(sb.ToString());
        }
    }
}
