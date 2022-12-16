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
      string nameInput = "test";
      string descriptionInput = "test";
      Vendor newVendor = new Vendor(nameInput, descriptionInput);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameProperty_String()
    {
      string nameInput = "Super Caffe";      
      string descriptionInput = "test";
      Vendor newVendor = new Vendor(nameInput, descriptionInput);
      Assert.AreEqual(nameInput, newVendor.Name);
    }

    [TestMethod]
    public void GetDescripton_ReturnsDescriptionProperty_String()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput);
      Assert.AreEqual(descriptionInput, newVendor.Description);
    }
  }
}