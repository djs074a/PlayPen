using System;
using System.Collections.Generic;
using System.Linq;

namespace SandPit
{
    public class ArabicToRomanNumerals
    {
        private readonly List<Tuple<int, string>> list = new List<Tuple<int, string>>
            {
            new Tuple<int, string>(1000,"M"),
            new Tuple<int, string>(900,"CM"),
            new Tuple<int, string>(500,"D"),
            new Tuple<int, string>(400,"CD"),
            new Tuple<int, string>(100,"C"),
            new Tuple<int, string>(90,"XC"),
            new Tuple<int, string>(50,"L"),
            new Tuple<int, string>(40,"XL"),
            new Tuple<int, string>(10,"X"),
            new Tuple<int, string>(9,"IX"),
            new Tuple<int, string>(5, "V" ),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>( 1, "I" )
            };

        public string Convert(int number)
        {

            if (number == 0) return ("");

            var converter = LookupConversion(number);

            return converter.Item2 + Convert(number - converter.Item1);
        }

        private Tuple<int, string> LookupConversion(int number)
        {
            return list.First(p => p.Item1 <= number);
        }
    }
}