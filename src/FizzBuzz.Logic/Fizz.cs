using System;
using FizzBuzz.Exceptions;

namespace FizzBuzz.Logic
{
    public class Fizz
    {
        public string FizzByThree(double itterator)
        {
            if (itterator % 3 == 0)
                return "Fizz";
            else if (itterator % 3 != 0)
                throw new ModNotDivideByThree();
            return "";
        }

        public string BuzzByFive(double itterator)
        {
            if (itterator % 5 == 0)
                return "Buzz";
            else if (itterator % 5 != 0)
                throw new ModNotDivideByFive();
            return "";
        }

        public string FizzBuzz(double itterator)
        {
            if (itterator % 3 == 0 && itterator % 5 == 0)
            {
                return "FizzBuzz";
            }
                
            else if (itterator % 5 != 0 && itterator % 3 != 0)
                throw new ModNotDivideByThreeAndFive();

            return "";
        }

    }
}
