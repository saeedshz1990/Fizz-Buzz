using System;

namespace FizzBuzz.Application
{
    public class Test
    {
        public void CheckNumberItterator()
        {

            for (int i = 0; i < 10000; i++)
            {
                 if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                 if (i % 3 == 0&& i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
        }

    }
}
