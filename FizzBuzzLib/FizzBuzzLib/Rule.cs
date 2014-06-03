using System;
using System.Linq;

namespace FizzBuzzLib
{
    public class Rule
    {
        private readonly int _denominator;
        private readonly string _result;

        public Rule(int denominator, string result)
        {
            _denominator = denominator;
            _result = result;
        }

        public bool IsMatch(int number)
        {
            return (number % _denominator) == 0;
        }

        public string GetResult()
        {
            return _result;
        }
    }
}
