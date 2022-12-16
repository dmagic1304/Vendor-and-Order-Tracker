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
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameProperty_String()
    {
      string nameInput = "Super Caffe";
      Vendor newVendor = new Vendor(nameInput);
      Assert.AreEqual(nameInput, newVendor.Name);
    }
  }
}