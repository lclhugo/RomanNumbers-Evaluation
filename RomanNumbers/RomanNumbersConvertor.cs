namespace RomanNumbers
{
    public abstract class RomanNumbersConvertor
    {
        public static string Convert(uint n)
            => n switch
            {
                1 => new string('I', 1),
                _ => "Invalid Number"
            };
    }
}