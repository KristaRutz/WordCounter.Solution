using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounter_HasTypeRepeatCounter_True()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
    }

    [TestMethod]
    public void Validate_IdentifiesEmptyWordInputs_False()
    {
      RepeatCounter emptyWord = new RepeatCounter("", "test");
      Assert.AreEqual(false, emptyWord.Validate());
    }

    [TestMethod]
    public void Validate_IdentifiesEmptyStringInputs_False()
    {
      RepeatCounter emptySearchStr = new RepeatCounter("test", "");
      Assert.AreEqual(false, emptySearchStr.Validate());
    }

    [TestMethod]
    public void Validate_IdentifiesNonEmptyInputs_True()
    {
      RepeatCounter example = new RepeatCounter("test", "test");
      Assert.AreEqual(true, example.Validate());
    }

    [TestMethod]
    public void Matches_IdentifiesEmptyWordInput_Zero()
    {
      RepeatCounter example = new RepeatCounter("", "test");
      Assert.AreEqual(0, example.Matches());
    }

    [TestMethod]
    public void Matches_IdentifiesEmptyStringInput_Zero()
    {
      RepeatCounter example = new RepeatCounter("test", "");
      Assert.AreEqual(0, example.Matches());
    }

    [TestMethod]
    public void Matches_SingleWordIdenticalStringInput_One()
    {
      RepeatCounter example = new RepeatCounter("test", "test");
      RepeatCounter example2 = new RepeatCounter("Hello", "Hello");
      Assert.AreEqual(1, example.Matches());
      Assert.AreEqual(1, example2.Matches());
    }

    [TestMethod]
    public void Matches_StringMadeOfOnlyWordInput_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "test test test");
      Assert.AreEqual(3, example.Matches());
    }

    [TestMethod]
    public void Matches_CheckFrequencyOfInput_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "this test is a test");
      Assert.AreEqual(2, example.Matches());
    }

    [TestMethod]
    public void Matches_CheckFrequencyOfPerfectMatch_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "this test is still testing");
      Assert.AreEqual(1, example.Matches());
    }

    [TestMethod]
    public void Matches_CheckFrequencyOfMatchWithPunctuation_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "this test is a 'test.'");
      Assert.AreEqual(2, example.Matches());
    }
  }
}