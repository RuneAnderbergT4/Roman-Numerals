using System;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            for (int i = 0; i < 4000; i++)
            {
                Console.WriteLine(i + ":   " + converter.IntToRomanNumerals(i));
            }

            Console.ReadLine();
        }
    }
}
