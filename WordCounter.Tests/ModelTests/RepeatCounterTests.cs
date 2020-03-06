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
    public void RepeatCounter_IdentifiesEmptyWordInput_Zero()
    {
      RepeatCounter example = new RepeatCounter("", "test");
      Assert.AreEqual(0, example.Matches());
    }

    [TestMethod]
    public void RepeatCounter_IdentifiesEmptyStringInput_Zero()
    {
      RepeatCounter example = new RepeatCounter("test", "");
      Assert.AreEqual(0, example.Matches());
    }

    [TestMethod]
    public void RepeatCounter_SingleWordSingleStringInput_One()
    {
      RepeatCounter example = new RepeatCounter("test", "test");
      RepeatCounter example2 = new RepeatCounter("Hello", "Hello");
      Assert.AreEqual(1, example.Matches());
      Assert.AreEqual(1, example2.Matches());
    }

    [TestMethod]
    public void RepeatCounter_SingleWordMultiSameStringInput_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "test test test");
      Assert.AreEqual(3, example.Matches());
    }

    [TestMethod]
    public void RepeatCounter_CheckFrequencyOfInput_Int()
    {
      RepeatCounter example = new RepeatCounter("test", "this test is a test");
      Assert.AreEqual(2, example.Matches());
    }
  }
}