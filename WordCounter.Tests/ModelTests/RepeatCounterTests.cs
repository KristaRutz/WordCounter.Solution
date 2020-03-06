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
  }
}