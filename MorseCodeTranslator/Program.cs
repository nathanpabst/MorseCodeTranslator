using System;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true) loop allows the user to continue using the program 
            while (true)
            {
                //prompt user for input
            Console.Write(": ");
            
            string input = Console.ReadLine();
                //the loop stops when input is null or whitespace 
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
