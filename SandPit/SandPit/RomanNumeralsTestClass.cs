using NUnit.Framework;

namespace SandPit
{
    [TestFixture]
    public class RomanNumeralsTestClass
    {
        [Test]  
        public void Convert_Zero_EmptyString()
        {
            ArabicToRomanNumerals arabicToRomanNumerals = new ArabicToRomanNumerals();

            string result = arabicToRomanNumerals.Convert(0);

            Assert.AreEqual("",result);
        }

        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(10,"X")]
        [TestCase(40,"XL")]
        [TestCase(50,"L")]
        [TestCase(90,"XC")]
        [TestCase(100,"C")]
        [TestCase(400,"CD")]
        [TestCase(500,"D")]
        [TestCase(900,"CM")]
        [TestCase(1000,"M")]
        [TestCase(3497,"MMMCDXCVII")]
        public void Convert_ArabicSingleNumber_RomanSingleNumber(int number, string expected)
        {
            ArabicToRomanNumerals arabicToRomanNumerals = new ArabicToRomanNumerals();

            string result = arabicToRomanNumerals.Convert(number);

            Assert.AreEqual(expected,result);
        }
    }
}
