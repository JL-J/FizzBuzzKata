using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (IsDivisableBy(15, input))
                return "FizzBuzz";
            else if (IsDivisableBy(3, input))
                return "Fizz";
            else if (IsDivisableBy(5, input))
                return "Buzz";
            else
                return input.ToString();
        }

        static bool IsDivisableBy(int divisor, int input)
        {
            return (input % divisor) == 0;   
        }
    }
}
