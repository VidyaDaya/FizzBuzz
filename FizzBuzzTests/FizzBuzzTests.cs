using System;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ReadValueReturnValue_Test([Values(1,2,4,7,8)] int input)
        {
            string output= FizzBuzzGame.ReturnValue(input);
            Assert.AreEqual(input.ToString(),output);
        }

        [Test]
        public void Read3Factors_ReturnFizz_Test([Values(3,6,9,12)] int input)
        {
            string output = FizzBuzzGame.ReturnValue(input);
            Assert.AreEqual("fizz", output);
        }

        [Test]
        public void Read5Factors_ReturnBuzz_Test([Values(5,10,25,20)]int input)
        {
            string output = FizzBuzzGame.ReturnValue(input);
            Assert.AreEqual("buzz", output);
        }
        
        [Test]
        public void Read15Factors_ReturnFizzBuzz_Test([Values(15,30,45)] int input)
        {
            string output = FizzBuzzGame.ReturnValue(input);
            Assert.AreEqual("fizz buzz", output);
        }

    }
}
