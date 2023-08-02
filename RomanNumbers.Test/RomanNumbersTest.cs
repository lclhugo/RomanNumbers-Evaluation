using static RomanNumbers.RomanNumbersConvertor;

namespace RomanNumbers.Test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "When I convert 1 to a roman number, then I get 'I'")]
        [InlineData(1, "I")]
        public void Test1(uint n, string expected)
        {
            var romanNumber = Convert(n);
            Assert.Equal(expected, romanNumber);
        }
    }
}