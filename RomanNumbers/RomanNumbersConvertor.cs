namespace RomanNumbers
{
    public abstract class RomanNumbersConvertor
    {
        public static string Convert(uint n)
            => n switch
            {
                1 => new string('I', 1),
                2 => new string('I', 2),
                3 => new string('I', 3),
                4 => "IV",
                5 => "V",
                _ => "Invalid Number"
            };
    }
}