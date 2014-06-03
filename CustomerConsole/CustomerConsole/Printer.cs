using System;
using System.Collections.Generic;
using System.Linq;
using CustomerConsole.CustomerRules;
using FizzBuzzLib;

namespace CustomerConsole
{
    public class Printer
    {
        private static FizzBuzz _fizzBuzz;

        public static void Main(string[] args)
        {
            var rules = new List<IRule>();
            rules.Add(new Rule(3, "Fizz"));
            rules.Add(new Rule(5, "Buzz"));
            rules.Add(new NonStandardCustomerRule());

            _fizzBuzz = new FizzBuzz(rules);
            //PrintFizzBuzzUpTo(Int32.MaxValue);
            PrintFizzBuzzUpTo(46);

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