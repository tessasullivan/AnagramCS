using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
        List<string> tempList = new List<string>{"beer", "beard"};
        Anagram newAnagram = new Anagram("Test", tempList);
        Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }

    [TestMethod]
    public void GetUserWord_ReturnsWordInputted_String()
    {
        string word = "bread";
        List<string> tempList = new List<string>{"beer", "beard"};
        Anagram newAnagram = new Anagram(word, tempList);
        string result = newAnagram.GetWord();
        Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void GetUserListToTest_ReturnsListInputted_List()
    {
        List<string> tempList = new List<string>{"beer", "beard"};
        Anagram newAnagram = new Anagram("bread", tempList);
        // string result = newAnagram.GetTestList();
        CollectionAssert.AreEqual(tempList, newAnagram.GetTestList());
    }

    [TestMethod]
    public void CheckIfAnagram_SameWordEntered_True()
    {
        string stringToTest = "bread";
        List<string> tempList = new List<string>{"bread"};
        Anagram newAnagram = new Anagram("bread", tempList);
        Assert.AreEqual(true, newAnagram.CheckIfAnagram(stringToTest));
    }
    [TestMethod]
    public void CheckIfAnagram_WordLengthsDiffer_False()
    {
        string stringToTest = "beer";
        List<string> tempList = new List<string>{"bread"};
        Anagram newAnagram = new Anagram("bread", tempList);
        Assert.AreEqual(false, newAnagram.CheckIfAnagram(stringToTest));
    }

    [TestMethod]
    public void ConvertWordToArray_Word_CharArray()
    {
        string stringToTest = "beer";
        char[] test = {'b', 'e', 'e', 'r'};
        List<string> tempList = new List<string>{"bread"};
        Anagram newAnagram = new Anagram("bread", tempList);
        CollectionAssert.AreEqual(test, newAnagram.ConvertWordToArray(stringToTest));
    }

    [TestMethod]
    public void SortArray_CharArray_IsSorted()
    {
        char[] test = {'a','b', 'd','e','r'};
        char[] testSort = {'r', 'a', 'e', 'd', 'b'};
        List<string> tempList = new List<string>{"bread"};
        Anagram newAnagram = new Anagram("bread", tempList);
        CollectionAssert.AreEqual(test, newAnagram.SortArray(testSort));
    }

    [TestMethod]
    public void CheckIfAnagram_WordIsAnagram_True()
    {
        string stringToTest = "bread";
        List<string> tempList = new List<string>{"beard"};
        Anagram newAnagram = new Anagram("beard", tempList);
        Assert.AreEqual(true, newAnagram.CheckIfAnagram(stringToTest));
    }
    [TestMethod]
    public void CheckIfAnagram_WordIsNotAnagram_False()
    {
        string stringToTest = "bread";
        List<string> tempList = new List<string>{"beers"};
        Anagram newAnagram = new Anagram("beers", tempList);
        Assert.AreEqual(false, newAnagram.CheckIfAnagram(stringToTest));
    }

    [TestMethod]
    public void CheckWordList_WordListContainsAnagram_ListOfAnagrams()
    {
        List<string> expectedResultList = new List<string>{"beard"}; 
        List<string> listToCheck = new List<string>{"beers", "beard"};
        Anagram newAnagram = new Anagram("bread", listToCheck);
        foreach (string word in listToCheck)
        {
            Console.WriteLine(word);
        }
        CollectionAssert.AreEqual(expectedResultList, newAnagram.CheckWordList());
    }
  }
}