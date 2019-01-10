using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0)
               return "Fizz";
            if (input == 5)
                return "Buzz";
            return input.ToString();
        }
    }
}
