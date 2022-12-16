using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void OrderConstructor_CreateOrderObjectInstance_Order()
    {
      string titleInput = "Bread";
      Order newOrder = new Order(titleInput);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleProperty_String()
    {
      string titleInput = "Bread";
      Order newOrder = new Order(titleInput);
      Assert.AreEqual(titleInput, newOrder.Title);
    }
  }
}