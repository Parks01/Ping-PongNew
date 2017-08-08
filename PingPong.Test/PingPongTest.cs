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
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");

          List<string> actualList = PingPong.CountToNumber(2);

          CollectionAssert.AreEqual(expectedList, actualList);
      }

      [TestMethod]
      public void CountToNumber_MultiplesOfThreePing_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");
          expectedList.Add("ping");

          List<string> actualList = PingPong.CountToNumber(3);

          CollectionAssert.AreEqual(expectedList, actualList);
      }

      [TestMethod]
      public void CountToNumber_MultiplesOfFivePong_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");
          expectedList.Add("ping");
          expectedList.Add("4");
          expectedList.Add("pong");

          List<string> actualList = PingPong.CountToNumber(5);

          CollectionAssert.AreEqual(expectedList, actualList);
      }
  }
}
