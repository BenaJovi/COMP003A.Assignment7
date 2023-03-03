using System;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");                                     // Section Header 

            Console.Write("Please enter a letter: ");                                                 // Lines 11-18 Will ask for a character and a word
            char CharacterInput = Convert.ToChar(Console.ReadLine());                                 // Code will then check how many times that character 
            Console.Write("Please enter a word: ");                                                   // Is in the enter word.  
            string word = Console.ReadLine();
            CharacterInput = char.ToLower(CharacterInput);
            word = word.ToLower();
            int counter = CharacterCounter(word, CharacterInput);
            Console.WriteLine($"There are {counter} letter {CharacterInput} in the word {word}\n");

            SectionSeparator("Array- IsPalindrome Section");                                         // Section Header 

            Console.Write("Please enter a word to check if it is a palindrome:");                    // Lines 22-24 will use metheod "IsPalindrome" to check
            string InputWord = Console.ReadLine();                                                   // if the word entered is a palindrome or not. 
            Console.Write($"Is the word {InputWord} palindrome:{IsPalindrome(InputWord)}\n");

            SectionSeparator("List - Add Section");                                                  // Section Header 
                      
            

            List<string> names = new List<string>();                                                // Lines 30-56 will use to traverse methods that will 
            char userInput = default;                                                               // display the entered information how the information 
            string nameInput;                                                                       // enterd and the infomation entered backwards.
            bool end;

            do                                                                                      // Lines 35-48 is a do statment that allows the user 
            {                                                                                       // to create a list and end the list whenever by pressing (e)
                Console.Write("Please enter a name: ");
                nameInput = Convert.ToString(Console.ReadLine());
                names.Add(nameInput);
                Console.Write("Press any key to continue adding names or press (e) to exit: ");
                userInput = Convert.ToChar(Console.ReadLine());
                userInput = char.ToLower(userInput);
                if (userInput == 'e')
                {
                    break;
                }
            }  
            while (true); 
            
            SectionSeparator("List - Traversal"); 
            traverseList(names);
            
            SectionSeparator("List - Reverse Traversal");
            traverseListReverse(names);

        }

        /// <summary>
        /// Section Header 
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

        /// <summary>
        /// Checks whether input is a palidrome
        /// </summary>
        /// <param name="Inputword"></param>
        /// <returns></returns>
        static bool IsPalindrome(string Inputword)
        {
            Inputword = Inputword.ToLower();
            char[] charArray = Inputword.ToCharArray();
            Array.Reverse(charArray);
            string reverseInput = new string(charArray);

            return reverseInput == Inputword;
        }

        /// <summary>
        /// Traverses list
        /// </summary>
        /// <param name="list"></param>
        static void traverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Reverses traversed list
        /// </summary>
        /// <param name="list"></param>
        static void traverseListReverse(List<string> list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}
