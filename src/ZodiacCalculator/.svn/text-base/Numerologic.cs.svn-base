using System;
using System.Collections.Generic;
using System.Text;

namespace ZodiacCalculator
{
    public class Numerologic
    {

        public static int[] GetDigits(Int64 number)
        {
            string temp = number.ToString();


            int[] rtn = new int[temp.Length];


            for (int i = 0; i < rtn.Length; i++)
            {
                rtn[i] = int.Parse(temp[i].ToString());
            }
            return rtn;
        }

        public static int SumDigits(int[] digits)
        {
            int counter = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                counter += digits[i];
            }

            return counter;
        }

    }
}
