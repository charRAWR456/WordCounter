using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWordCounter_SentenceBlank_PleaseReEnter()
    {
      WordCount newCombination = new WordCount();
      Assert.AreEqual("Please enter a word AND sentence", newCombination.FieldCheck("Hello",""));
    }
    [TestMethod]
    public void IsWordCounter_WordBlank_PleaseReEnter()
    {
      WordCount newCombination = new WordCount();
      Assert.AreEqual("Please enter a word AND sentence", newCombination.FieldCheck("","How was your day?"));
    }
    [TestMethod]
    public void IsWordCounter_HowManyAre_PleaseReEnter()
    {
      WordCount newCombination = new WordCount();
      Assert.AreEqual(1, newCombination.RepeatCounter("are","how are you"));
    }
    [TestMethod]
    public void IsWordCounter_HowManyThe_PleaseReEnter()
    {
      WordCount newCombination = new WordCount();
      Assert.AreEqual(2, newCombination.RepeatCounter("the","The fox and the hound"));
    }
    [TestMethod]
    public void IsWordCounter_HowManyKitten_PleaseReEnter()
    {
      WordCount newCombination = new WordCount();
      Assert.AreEqual(0, newCombination.RepeatCounter("kitten","Puppies are very energetic and cute"));
    }
  }
}
