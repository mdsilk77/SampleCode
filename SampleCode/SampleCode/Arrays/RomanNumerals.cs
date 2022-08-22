using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    public class RomanNumerals
    {
        public static int RomanToInt(string input)
        {
            int intResult = 0;
            char prevNumeral = ' ';
            char curNumeral = ' ';
            string finalNumeral = null;

            foreach (char ch in input)
            {
                prevNumeral = curNumeral;
                curNumeral = ch;

                if (prevNumeral > ' ')
                {
                    finalNumeral = DerriveFinalNumeral(prevNumeral, curNumeral);
                    intResult = CalculateValue(finalNumeral, intResult);

                    if (finalNumeral.Length == 2)
                    {
                        curNumeral = ' ';
                    }
                }

            }
            if (finalNumeral.Length < 2)
            {
                intResult = CalculateValue(finalNumeral, intResult);
            }

            return intResult;
        }


        public static string DerriveFinalNumeral(char prevNum, char curNum)
        {
            string finalNumeral = null;

            if (prevNum == 'I' && curNum == 'V')
            {
                finalNumeral = "IV";
            }
            else if (prevNum == 'I' && curNum == 'X')
            {
                finalNumeral = "IX";
            }
            else if (prevNum == 'X' && curNum == 'L')
            {
                finalNumeral = "XL";
            }
            else if (prevNum == 'X' && curNum == 'C')
            {
                finalNumeral = "XC";
            }
            else if (prevNum == 'C' && curNum == 'D')
            {
                finalNumeral = "CD";
            }
            else if (prevNum == 'C' && curNum == 'M')
            {
                finalNumeral = "CM";
            }
            else
            {
                finalNumeral = prevNum.ToString();
            };

            return finalNumeral;
        }


        public static int CalculateValue(string numeral, int sumValue)
        {
            int value = 0;

            switch (numeral)
            {
                case "I":
                    value = 1;
                    break;
                case "V":
                    value = 5;
                    break;
                case "X":
                    value = 10;
                    break;
                case "L":
                    value = 50;
                    break;
                case "C":
                    value = 100;
                    break;
                case "D":
                    value = 500;
                    break;
                case "M":
                    value = 1000;
                    break;
                case "IV":
                    value = 4;
                    break;
                case "IX":
                    value = 9;
                    break;
                case "XL":
                    value = 40;
                    break;
                case "XC":
                    value = 90;
                    break;
                case "CD":
                    value = 400;
                    break;
                case "CM":
                    value = 900;
                    break;
                default:
                    value = 0;
                    break;
            }

            return sumValue += value;

        }
    }
}
