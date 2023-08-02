namespace RomanNumbers
{
    public abstract class RomanNumbersConvertor
    {
        public static string Convert(uint n)
            => n switch
            {
                <= 3 => new string('I', (int)n),
                4 => "IV",
                _ => 'V' + Convert(n - 5)
            };
    }
}