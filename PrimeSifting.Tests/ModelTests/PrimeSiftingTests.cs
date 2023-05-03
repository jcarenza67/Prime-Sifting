using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System.Collections.Generic;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeSiftingTests
  {
    [TestMethod]
    public void PrimeSiftingConstructor_CreatesInstanceOfPrimeSifting_PrimeSifting()
    {
      PrimeSifter newPrimeSifter = new PrimeSifter();
      Assert.AreEqual(typeof(PrimeSifter), newPrimeSifter.GetType());
    }

    [TestMethod]
    public void SetNumber_SetsValueOfNumber_Void()
    {
      PrimeSifter newPrimeSifter = new PrimeSifter();
      int newNumber = 8;
      newPrimeSifter.Number = newNumber;
      Assert.AreEqual(newNumber, newPrimeSifter.Number);
    }

    [TestMethod]
    public void RemoveNonPrimes_ReturnsListOfPrimes_List()
    {
      PrimeSifter newPrimeSifter = new PrimeSifter();
      int newNumber = 15;
      List<int> newList = newPrimeSifter.RemoveNonPrimes(newNumber);
      CollectionAssert.AreEqual(new List<int> {2,3,5,7,11,13}, newList);
    }
  }
}