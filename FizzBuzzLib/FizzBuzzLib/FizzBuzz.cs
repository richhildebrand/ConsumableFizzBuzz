using System;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public string GetSentenceFor(int number)
        {
            var sentence = "";
            sentence += GetFizz(number);
            sentence += GetBuzz(number);
            sentence += GetNumber(number, sentence);

            return sentence;
        }

        private string GetNumber(int number, string sentence)
        {
            if (sentence == "")
            {
                return number.ToString();
            }

            return "";
        }
  
        private string GetFizz(int number)
        {
            if (IsDivisibleByThree(number))
            {
                return "Fizz";
            }

            return "";
        }

        private string GetBuzz(int number)
        {
            if (IsDivisibleByFive(number))
            {
                return "Buzz";
            }

            return "";
        }

        private bool IsDivisibleByThree(int number)
        {
            return (number % 3) == 0;
        }

        private bool IsDivisibleByFive(int number)
        {
            return (number % 5) == 0;
        }
    }
}