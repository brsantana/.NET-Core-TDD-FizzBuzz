using System;
using FizzBuzz.Library;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }
        }
    }
}
