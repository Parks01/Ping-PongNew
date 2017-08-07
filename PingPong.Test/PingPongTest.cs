using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongApp.Models;

namespace PingPongApp.Tests
{
  [TestClass]
  public class PingPongTest
  {
      [TestMethod]
      public void CountToNumber_IsAnArrayofNumbers_True()
      {
          List<int> expectedList = new List<int> {};
          expectedList.Add(1);
          expectedList.Add(2);

          List<int> actualList = new List<int> {};
          actualList.CountToNumber(2);

          Assert.AreEqual(expectedList, actualList);
      }
  }
}
