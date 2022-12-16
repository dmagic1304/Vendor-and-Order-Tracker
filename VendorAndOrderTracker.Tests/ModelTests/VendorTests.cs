using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.TestTools
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameProperty_String()
    {
      string nameInput = "Super Caffe";
      Vendor newVendor = new Vendor(nameInput, "test");
      Assert.AreEqual(nameInput, newVendor.Name);
    }

    [TestMethod]
    public void GetName_ReturnsNameProperty_String()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput);
      Assert.AreEqual(descriptionInput, newVendor.Description);
    }
  }
}