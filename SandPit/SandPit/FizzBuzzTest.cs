using System;
using NUnit.Framework;
namespace SandPit
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;
        [SetUp]
        public void Init()
        {
            _fizzBuzz = new FizzBuzz();
        }


        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4,"4")]
        [TestCase(7,"7")]
        public void convert_Number_ReturnsNumber(int number, string expected)
        {
            string result = _fizzBuzz.Convert(number);

            Assert.AreEqual(expected,result);
        }

        [TestCase(3,"Fizz")]
        [TestCase(6,"Fizz")]
        public void Convert_MultipleOfThree_ReturnFizz(int number, string expected)
        {
            string result = _fizzBuzz.Convert(number);

            Assert.AreEqual(expected,result);

        }

        [TestCase(5,"Buzz")]
        [TestCase(10,"Buzz")]
        public void Convert_MultipleOfFive_ReturnBuzz(int number, string expected)
        {
            string result = _fizzBuzz.Convert(number);

            Assert.AreEqual(expected,result);
        }

        [TestCase(15,"FizzBuzz")]
        [TestCase(30,"FizzBuzz")]
        public void Convert_MultipleOfThreeAndFive_ReturnFizzBuzz(int number, string fizzbuzz)
        {

            string result = _fizzBuzz.Convert(number);

            Assert.AreEqual(fizzbuzz,result);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Convert_Zero_ThrowsException(int number)
        {
            var ex = Assert.Throws<ArgumentException>(() => _fizzBuzz.Convert(number));
        }

    }
}