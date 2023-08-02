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
    }
}