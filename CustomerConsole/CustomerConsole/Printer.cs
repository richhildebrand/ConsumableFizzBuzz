using System;
using System.Linq;
using FizzBuzzLib;

namespace CustomerConsole
{
    public class Printer
    {
        private static FizzBuzz _fizzBuzz;

        public static void Main(string[] args)
        {
            _fizzBuzz = new FizzBuzz();
            //PrintFizzBuzzUpTo(Int32.MaxValue);
            PrintFizzBuzzUpTo(100);
            Console.ReadKey();
        }

        public static void PrintFizzBuzzUpTo(int number)
        {
            for (var i = 1; i <= number; i++)
            {
                PrintFizzBuzzFor(i);
            }
        }

        public static void PrintFizzBuzzFor(int number)
        { 
            var sentence = _fizzBuzz.GetSentenceFor(number);
            Console.WriteLine(sentence);
        }
    }
}