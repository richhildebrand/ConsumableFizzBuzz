using System;
using System.Linq;
using FizzBuzzLib;

namespace CustomerConsole.CustomerRules
{
    public class NonStandardCustomerRule : IRule
    {
        public bool IsMatch(int number)
        {
            string meaningOfLive = 42.ToString();
            return number.ToString().Contains(meaningOfLive);
        }

        public string GetResult()
        {
            return "But What is the Question?";
        }
    }
}
