using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLib;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzLibTests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            var rules = new List<IRule>();
            rules.Add(new IsEvenlyDivisible(3, "Fizz"));
            rules.Add(new IsEvenlyDivisible(5, "Buzz"));
            _fizzBuzz = new FizzBuzz(rules);
        }

        [Test]
        public void ReturnOne_WhenGivenOne()
        {
            var sentence = _fizzBuzz.GetSentenceFor(1);
            sentence.Should().Be("1");
        }

        [Test]
        public void ReturnFizz_WhenGivenThree()
        {
            var sentence = _fizzBuzz.GetSentenceFor(3);
            sentence.Should().Be("Fizz");
        }

        [Test]
        public void ReturnBuzz_WhenGivenFive()
        {
            var sentence = _fizzBuzz.GetSentenceFor(5);
            sentence.Should().Be("Buzz");
        }

        [Test]
        public void ReturnFizzBuzz_WhenGiven15()
        {
            var sentence = _fizzBuzz.GetSentenceFor(15);
            sentence.Should().Be("FizzBuzz");
        }
    }
}