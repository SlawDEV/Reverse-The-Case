/*
 This program reverses the case of each letter in the string,
 converting lowercase letters to uppercase and uppercase letters
 to lowercase, and prints the resul.
 */

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = ReverseCase("HELlo world");
            Console.WriteLine(myString);
            


            Console.ReadKey();
        }
        static string ReverseCase(string sentence)
        {
            char[] newSentence = new char[sentence.Length];
            for(int i=0; i<sentence.Length; i++)
            {
                if (sentence[i]>=97 && sentence[i]<=122)
                {
                    newSentence[i] = (char)(sentence[i] - 32);
                }
                else if (sentence[i]>=65 && sentence[i]<=90)
                {
                    newSentence[i] = (char)(sentence[i] + 32);
                }
                else
                {
                    newSentence[i] = sentence[i];
                }
            }
            string result = new string(newSentence);
            return result;
        }
    }
}