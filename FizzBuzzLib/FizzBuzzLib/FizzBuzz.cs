﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private List<IRule> _rules;

        public FizzBuzz(List<IRule> rules)
        {
            _rules = rules;
        }

        public string GetSentenceFor(int number)
        {
            var sentence = "";

            foreach (var rule in _rules)
            {
                sentence += ApplyRule(rule, number);
            }

            return GetNumberOrSentence(sentence, number);
        }

        private string ApplyRule(IRule rule, int number)
        {
            if (rule.IsMatch(number))
            {
                return rule.GetResult();
            }

            return "";
        }

        private string GetNumberOrSentence(string sentence, int number)
        {
            if (sentence == "")
            {
                return number.ToString();
            }

            return sentence;
        }
    }
}