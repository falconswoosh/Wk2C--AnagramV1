using System;
using System.Collections.Generic;
using System.Linq;


namespace Anagram.Models
{
  public class AnagramModel
  {
    // public static List GetAnagrams(string word, List<string> inputs)
    // // List<string> groceryList = new List<string> {};
    // {

    // }
    public static bool IsAnagram(string input, string reference)
    {
      char[] inputArray = input.ToLower().ToCharArray();
      char[] referenceArray = reference.ToLower().ToCharArray();

      bool contains = true;
      foreach (char letter in inputArray)
      {
        if (!referenceArray.Contains(letter))
        {
          contains = false;
        }
      }
      return contains;
    }
  }
}
