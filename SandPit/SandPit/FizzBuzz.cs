using System;
using System.Globalization;

namespace SandPit
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            ValidateParameters(number);
            return CalulateResult(number);
        }

        private static string CalulateResult(int number)
        {
            String result = number.ToString(CultureInfo.InvariantCulture);
            if (IsMulipleOfThree(number) && IsMultipleOfFive(number))
                result = "FizzBuzz";
            else if (IsMulipleOfThree(number))
                result = "Fizz";
            else if (IsMultipleOfFive(number))
                result = "Buzz";
            return result;
        }

        private static void ValidateParameters(int number)
        {
            if (number <= 0)
                throw new ArgumentException();
        }

        private static bool IsMultipleOfFive(int number)
        {
            return number%5 == 0;
        }

        private static bool IsMulipleOfThree(int number)
        {
            return number%3 == 0;
        }
    }
}