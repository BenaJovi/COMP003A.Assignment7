using System;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");
            
            Console.Write("Please enter a letter: ");
            char CharacterInput= Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();
            CharacterInput = char.ToLower(CharacterInput); 
            word = word.ToLower(); 
            int counter = CharacterCounter(word, CharacterInput);
            Console.WriteLine($"There are {counter} letter {CharacterInput} in the word {word}\n");

            SectionSeparator("Array- IsPalindrome Section");

            Console.Write("Please enter a word to check if it is a palindrome:");
            string InputWord = Console.ReadLine();  

            Console.Write($"Is the word {InputWord} palindrome:{IsPalindrome(InputWord)}");

            SectionSeparator("List - Add Section");

            Console.Write("Please enter a Name: ");
            string name= Console.ReadLine();    



        }




        /// <summary>
        /// Section Seperator 
        /// </summary>
        /// <param name="section"></param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t{section} Section\n" + "".PadRight(50, '*'));
        }

        /// <summary>
        /// Counts how many selected letters are in the word.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="CharacterInput"></param>
        /// <returns></returns>
        static int CharacterCounter(string word, char CharacterInput)
        {
            int counter = 0;
            foreach (char c in word)
            {
                if (CharacterInput == c)
                { 
                counter++;
                 }
            }
             return counter;
            }
        static bool IsPalindrome(string Inputword)
        {
            Inputword = Inputword.ToLower();
            char[] charArray = Inputword.ToCharArray();
            Array.Reverse(charArray);
            string reverseInput = new string (charArray);
            
            return reverseInput==Inputword ;
        }

        static void TraverseList(List<string>list)
        {
            
        }
        static void TraverseListReverse(List<string>list)
        {

        }

    }


}
