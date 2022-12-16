using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorAndOrderTracker.Models;

namespace VendorAndoRderTracker.TestTools
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}