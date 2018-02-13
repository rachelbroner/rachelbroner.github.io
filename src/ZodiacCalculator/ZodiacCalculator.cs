using System;
using System.Collections.Generic;
using System.Text;

namespace ZodiacCalculator
{


    public class ZodiacCalculator
    {

        private Dictionary<char, int> _nameNumberIndex = new Dictionary<char, int>();


        public ZodiacCalculator()
        {
            InitNameNumberIndex();
            

        }

        private void InitNameNumberIndex()
        {
            _nameNumberIndex.Add('s', 1);
            _nameNumberIndex.Add('j', 1);
            _nameNumberIndex.Add('a', 1);
            _nameNumberIndex.Add('א', 1);
            _nameNumberIndex.Add('י', 1);
            _nameNumberIndex.Add('ק', 1);

            _nameNumberIndex.Add('t', 2);
            _nameNumberIndex.Add('k', 2);
            _nameNumberIndex.Add('b', 2);
            _nameNumberIndex.Add('ב', 2);
            _nameNumberIndex.Add('כ', 2);
            _nameNumberIndex.Add('ך', 2);
            _nameNumberIndex.Add('ר', 2);

            _nameNumberIndex.Add('u', 3);
            _nameNumberIndex.Add('l', 3);
            _nameNumberIndex.Add('c', 3);
            _nameNumberIndex.Add('ג', 3);
            _nameNumberIndex.Add('ל', 3);
            _nameNumberIndex.Add('ש', 3);

            _nameNumberIndex.Add('v', 4);
            _nameNumberIndex.Add('m', 4);
            _nameNumberIndex.Add('d', 4);
            _nameNumberIndex.Add('ד', 4);
            _nameNumberIndex.Add('מ', 4);
            _nameNumberIndex.Add('ם', 4);
            _nameNumberIndex.Add('ת', 4);

            _nameNumberIndex.Add('w', 5);
            _nameNumberIndex.Add('n', 5);
            _nameNumberIndex.Add('e', 5);
            _nameNumberIndex.Add('ה', 5);
            _nameNumberIndex.Add('נ', 5);
            _nameNumberIndex.Add('ן', 5);

            _nameNumberIndex.Add('x', 6);
            _nameNumberIndex.Add('o', 6);
            _nameNumberIndex.Add('f', 6);
            _nameNumberIndex.Add('ו', 6);
            _nameNumberIndex.Add('ס', 6);

            _nameNumberIndex.Add('y', 7);
            _nameNumberIndex.Add('p', 7);
            _nameNumberIndex.Add('g', 7);
            _nameNumberIndex.Add('ז', 7);
            _nameNumberIndex.Add('ע', 7);

            _nameNumberIndex.Add('z', 8);
            _nameNumberIndex.Add('q', 8);
            _nameNumberIndex.Add('h', 8);
            _nameNumberIndex.Add('ח', 8);
            _nameNumberIndex.Add('פ', 8);
            _nameNumberIndex.Add('ף', 8);

            _nameNumberIndex.Add('r', 9);
            _nameNumberIndex.Add('i', 9);
            _nameNumberIndex.Add('ט', 9);
            _nameNumberIndex.Add('צ', 9);
            _nameNumberIndex.Add('ץ', 9);
        }

        public string ZodiacSign(int day,int month,int year)
        {
            DateTime tempDate = new DateTime(year, month, day);
            return ZodiacSign(tempDate);
        }
        public string ZodiacSign(DateTime birthdate)
        {

            DateTime tempDate = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);


            if (new DateTime(DateTime.Now.Year, 3, 21) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 4, 20))
                return "Aries";

            if (new DateTime(DateTime.Now.Year, 4, 21) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 5, 20))
                return "Taurus";

            if (new DateTime(DateTime.Now.Year, 5, 21) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 6, 21))
                return "Gemini";

            if (new DateTime(DateTime.Now.Year, 6, 22) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 7, 22))
                return "Cancer";

            if (new DateTime(DateTime.Now.Year, 7, 23) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 8, 22))
                return "Leo";

            if (new DateTime(DateTime.Now.Year, 8, 23) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 9, 22))
                return "Virgo";

            if (new DateTime(DateTime.Now.Year, 9, 23) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 10, 23))
                return "Libra";

            if (new DateTime(DateTime.Now.Year, 10, 24) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 11, 21))
                return "Scorpio";

            if (new DateTime(DateTime.Now.Year, 11, 22) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 12, 21))
                return "Sagittarius";

            if (new DateTime(DateTime.Now.Year, 12, 22) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 12, 31))
                return "Capricorn";

            if (new DateTime(DateTime.Now.Year, 1, 1) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 1, 20))
                return "Capricorn";

            if (new DateTime(DateTime.Now.Year, 1, 21) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 2, 18))
                return "Aquarius";

            if (new DateTime(DateTime.Now.Year, 2, 19) <= tempDate && tempDate <= new DateTime(DateTime.Now.Year, 3, 20))
                return "Pisces";


            return "";
        }
        public string ZodiacSignHebrew(int day, int month, int year)
        {
            DateTime tempDate = new DateTime(year, month, day);
            return ZodiacSignHebrew(tempDate);
        }
        public string ZodiacSignHebrew(DateTime birthdate)
        {
            string tempStr = ZodiacSign(birthdate);
            switch (tempStr)
            {
                case "Aries":
                    return "טלה";
                case "Taurus":
                    return "שור";
                case "Gemini":
                    return "תאומים";
                case "Cancer":
                    return "סרטן";
                case "Leo":
                    return "אריה";
                case "Virgo":
                    return "בתולה";
                case "Libra":
                    return "מאזניים";
                case "Scorpio":
                    return "עקרב";
                case "Sagittarius":
                    return "קשת";
                case "Capricorn":
                    return "גדי";
                case "Aquarius":
                    return "דלי";
                case "Pisces":
                    return "דגים";
                default:
                    return "";
            }
        }

        public int BirthNumber(int day, int month, int year)
        {
            DateTime tempDate = new DateTime(year, month, day);
            return BirthNumber(tempDate);
        }
        public int BirthNumber(DateTime birthdate)
        {
            //return NormalizeDigitsNine(birthdate.Year);

            return CurrentNumber(birthdate);
        }

        public int CurrentNumber(DateTime birthdate)
        {
            string numberString = birthdate.Month.ToString() + birthdate.Day.ToString() + birthdate.Year.ToString();

            int number = int.Parse(numberString);

            return NormalizeDigitsNine(number);
        }


        public int NameNumber(string name)
        {

            string _name = name.Replace(" ", "").Trim().ToLower();

            char[] nameArr = _name.ToCharArray();


            int[] nameArrNumbers = new int[nameArr.Length];

            for (int i = 0; i < nameArr.Length; i++)
            {
                nameArrNumbers[i] = _nameNumberIndex[nameArr[i]];
            }

            return NormalizeDigitsNine(nameArrNumbers);

        }


        public int NormalizeDigitsNine(int number)
        {
            int digitSum = number;

            do
            {
                int[] digits = Numerologic.GetDigits(digitSum);
                digitSum = Numerologic.SumDigits(digits);
            }
            while (digitSum > 9);

            return digitSum;
        }


        public int NormalizeDigitsNine(int[] digits)
        {

            int[] tempDigits = new int[digits.Length];

            digits.CopyTo(tempDigits, 0);

            int digitSum = Numerologic.SumDigits(tempDigits);


            while (digitSum > 9)
            {
                tempDigits = Numerologic.GetDigits(digitSum);
                digitSum = Numerologic.SumDigits(tempDigits);
            };


            return digitSum;
        }



    }
}
