using RomanNumbers;
using System;

namespace RomanNumbersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (0 to exit):");

            while (true)
            {
                string input = Console.ReadLine();

                if (uint.TryParse(input, out uint number))
                {
                    if (number == 0)
                        break;

                    string romanNumeral = RomanNumbersConvertor.Convert(number);
                    Console.WriteLine($"Roman numeral: {romanNumeral}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer or 0 to exit.");
                }
            }

            Console.WriteLine("Exit");
        }
    }
}