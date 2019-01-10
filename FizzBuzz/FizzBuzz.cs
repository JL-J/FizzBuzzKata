using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0)
               return "Fizz";
            return input.ToString();
        }
    }
}
