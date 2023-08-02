using static RomanNumbers.RomanNumbersConvertor;

namespace RomanNumbers.Test
{
    public class RomanNumbersTest
    {
        [Theory(DisplayName = "When I convert an uint number to roman number, then I get the expected result")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        public void ConvertorTest(uint n, string expected)
        {
            var romanNumber = Convert(n);
            Assert.Equal(expected, romanNumber);
        }

        [Fact(DisplayName = "When I convert 6 to roman number, then I get VI")]
        public void TestSix()
        {
            var romanNumber = Convert(6);
            Assert.Equal("VI", romanNumber);
        }

        [Fact(DisplayName = "When I convert 7 to a Roman number, then I get VII")]
        public void TestSeven()
        {
            var number = 7;
            var romanNumber = RomanNumbersConvertor.Convert((uint)number);
            Assert.Equal("VII", romanNumber);
        }

        [Fact(DisplayName = "When I convert 8 to a Roman number, then I get VIII")]
        public void TestEight()
        {
            var number = 8;
            var romanNumber = RomanNumbersConvertor.Convert((uint)number);
            Assert.Equal("VIII", romanNumber);
        }

        [Fact(DisplayName = "When I convert 9 to a Roman number, then I get IX")]
        public void TestNine()
        {
            var number = 9;
            var romanNumber = RomanNumbersConvertor.Convert((uint)number);
            Assert.Equal("IX", romanNumber);
        }

        [Fact(DisplayName = "When I convert 10 to a Roman number, then I get X")]
        public void TestTen()
        {
            var number = 10;
            var romanNumber = RomanNumbersConvertor.Convert((uint)number);
            Assert.Equal("X", romanNumber);
        }
    }
}