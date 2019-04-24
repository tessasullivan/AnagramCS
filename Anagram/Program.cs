using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    class Program
    {
        public static void Main()
        {
            List<string> testList = new List<string> {};
            Anagram newAnagram = new Anagram("", testList);
            Console.WriteLine("Enter a word.");
            string wordToCheck = Console.ReadLine();
            Console.WriteLine("Now enter any words (seperated with spaces) you think may be anagrams of your first word.");
            string wordList = Console.ReadLine();
            testList = wordList.Split(' ').ToList();
            newAnagram.SetWord(wordToCheck);
            newAnagram.SetWordList(testList);
            List<string> resultList = newAnagram.CheckWordList();
            System.Console.WriteLine("Anagrams for the word " + wordToCheck + " include: ");

            foreach (string word in resultList)
            {
                System.Console.WriteLine(word);
            }
        }
    }
}