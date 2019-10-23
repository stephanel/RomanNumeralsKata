using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        Dictionary<int, string> mappings = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public string Convert(int input)
        {
            string result = string.Empty;

            foreach(var key in mappings.Keys)
            {
                var number = key;
                var stringValue = mappings[key];

                while(input >= number)
                {
                    result += stringValue;

                    input -= number;
                }
            }

            return result;
        }
    }
}
