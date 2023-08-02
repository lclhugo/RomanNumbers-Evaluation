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
            new object[] { 10, "X" },
            new object[] { 11, "XI" },
            new object[] { 12, "XII" },
            new object[] { 13, "XIII" },
            new object[] { 14, "XIV" },
            new object[] { 15, "XV" },
            new object[] { 16, "XVI" },
            new object[] { 17, "XVII" },
            new object[] { 18, "XVIII" },
            new object[] { 19, "XIX" }
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