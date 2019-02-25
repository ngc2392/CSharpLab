using System;

namespace Assignment2
{
    class VowelsAndConsonants
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string");

            string userString = Console.ReadLine();

            Console.WriteLine("You entered " + userString);

            int totalNumOfVowels = 0;
            int totalNumOfConsonants = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == 'a' || userString[i] == 'e' || userString[i] == 'i' || userString[i] == 'o'
                    || userString[i] == 'u' || userString[i] == 'A' || userString[i] == 'E' || userString[i] == 'I' || userString[i] == 'O'
                    || userString[i] == 'U' )
                {
                    totalNumOfVowels++;
                }
                else if (!Char.IsWhiteSpace(userString[i]))
                {
                    totalNumOfConsonants++;
                }
            }
            Console.WriteLine("There are " + totalNumOfVowels + " vowels and " + (totalNumOfConsonants) + " consonants in the string " + "\"" + userString + "\"");
        }
    }
}
