using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeTranslator
{
    static class Translator
    {
        //creating/initializing a dictionary to store the table of characters to morse codes
        //the Translator class is static, so all it's members must be too.
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
        {
            //key / value
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };

        //--------------------translate morse code to text-----------------
        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        //static constructor..runs before any other members
        static Translator()
        {
            //loop through key value pairs
            foreach (KeyValuePair<char, string> code in _textToMorse)
            {
                _morseToText.Add(code.Value, code.Key);
            }
        }
        

        //method to translate the text input into morse code and return
        public static string ToMorse(string input)
        {
            //List to store all the translated characters of text with initial capacity of input.Length
            List<string> output = new List<string>(input.Length);
            //loop through the input and find the corresponding value
            foreach (char character in input.ToUpper())
            {
                //use try/catch and KeyNotFoundException to handle invalid input
                try
                {
                    //use the key--character passed in--to index into the dictionary
                    //look up the character in the dictionary using the [character]
                    //assign the value to the morseCode variable 
                    string morseCode = _textToMorse[character];
                    //add the morseCode found to the output variable
                    output.Add(morseCode);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("!");
                }

            }

            return string.Join(" ", output);
        }
    }
}

