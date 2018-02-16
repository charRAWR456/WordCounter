using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWordCounter_RockOverScissors_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player one wins", newCombination.WinCondition("rock", "scissors"));
    }
  }
}
