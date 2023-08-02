namespace RomanNumbers.Test
{
    public class RomanNumbersTest
    {
        public static readonly object[][] TestData =
        {
            new object[] { 1, "I" },
            new object[] { 2, "II" },
            new object[] { 3, "III" },
            new object[] { 4, "IV" },
            new object[] { 5, "V" },
            new object[] { 6, "VI" },
            new object[] { 7, "VII" },
            new object[] { 8, "VIII" },
            new object[] { 9, "IX" },
            new object[] { 10, "X" }
        };

        [Theory(DisplayName = "When I convert an uint number to a Roman number, then I get the expected result")]
        [MemberData(nameof(TestData))]
        public void ConvertorTest(uint n, string expected)
        {
            var romanNumber = RomanNumbersConvertor.Convert(n);
            Assert.Equal(expected, romanNumber);
        }
    }
}