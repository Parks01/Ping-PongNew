using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongApp.Models;
using System.Collections.Generic;

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

          List<int> actualList = PingPong.CountToNumber(2);

          CollectionAssert.AreEqual(expectedList, actualList);
      }
  }
}
