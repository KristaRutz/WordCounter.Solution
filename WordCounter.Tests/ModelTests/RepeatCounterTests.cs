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
    public void RepeatCounter_IdentifiesSingleWordEmptyStringInput_Zero()
    {
      RepeatCounter example = new RepeatCounter("", "test");
      Assert.AreEqual(0, example.Matches());
    }
  }
}