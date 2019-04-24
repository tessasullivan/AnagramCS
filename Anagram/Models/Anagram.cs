using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Anagram
    {
        private string _word; 
        private List<string> _testList;
        public Anagram (string word, List<string> testList)
        {
            _word = word;
            _testList = testList;
        }

        public string GetWord()
        {
            return _word;
        }

        public void SetWord(string newWord)
        {
            _word = newWord;
        }
        public List<string> GetWordList()
        {
            return _testList;
        }
        public void SetWordList(List<string> wordList)
        {
            _testList = wordList;
        }

        public bool CheckIfAnagram(string stringToCheck)
        {
            if (_word == stringToCheck)
            {
                return true;
            } 
            else
            {
                // Make _word & stringToCheck into arrays
                // Sort the arrays and compare them
                char[] splitWord = ConvertWordToArray(_word);
                char[] splitStringToTest = ConvertWordToArray(stringToCheck);
                splitWord = SortArray(splitWord);
                splitStringToTest = SortArray(splitStringToTest);
                string splitWordJoined = String.Join("", splitWord);
                string splitStringToTestJoined = String.Join("", splitStringToTest);
                if ( splitWordJoined.Contains(splitStringToTestJoined) || splitStringToTestJoined.Contains(splitWordJoined))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public List<string> CheckWordList()
        {
            List<string> result = new List<string>{};
            foreach (string word in _testList)
            {
                if (CheckIfAnagram(word))
                {
                    result.Add(word);
                }
                
            }
            return result;
        }
        public char[] ConvertWordToArray(string stringToConvert)
        {
            // char[] convertedString = stringToConvert.ToCharArray();
            return stringToConvert.ToCharArray();
        }
        public char[] SortArray(char[] splitWord)
        {
            Array.Sort(splitWord);
            return splitWord;
        }
    }
}