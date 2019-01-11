using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (IsDivisableBy(15))
                return "FizzBuzz";
            else if (IsDivisableBy(3))
               return "Fizz";
            else if (IsDivisableBy(5))
                return "Buzz";
            else 
                return input.ToString();

            bool IsDivisableBy(int divisor)
            {
               return (input % divisor) == 0;   
            }
        }
    }
}
