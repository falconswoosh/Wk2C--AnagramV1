using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void GetAnagrams_SameLength_true()
    {
      Assert.AreEqual(true, AnagramModel.IsAnagram("Beard", "Bread"));
    }

    [TestMethod]
    public void GetAnagrams_SameChars_true()
    {
      Assert.AreEqual(true, AnagramModel.IsAnagram("Beard", "bread"));
    }
    [TestMethod]
    public void GetAnagrams_SameChars_true()
    {
      Assert.AreEqual(true, AnagramModel.IsAnagram("Beard", "bread"));
    }
  }
}
