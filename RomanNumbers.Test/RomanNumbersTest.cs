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
    }
}