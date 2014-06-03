using System;
using System.Linq;
using FizzBuzzLib;

namespace FizzBuzzLibTests
{
    public class CustomRule : IRule
    {
        public bool IsMatch(int number)
        {
            var isLucky = "777";
            return number.ToString().Contains(isLucky);
        }

        public string GetResult()
        {
            return "Lucky";
        }
    }
}
