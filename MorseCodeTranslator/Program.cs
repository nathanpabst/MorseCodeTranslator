using System;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.Write(": ");
            string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

            string output = Translator.ToMorse(input);

            Console.WriteLine(output);

            }
        }

        //Console.Read();
    }
}
