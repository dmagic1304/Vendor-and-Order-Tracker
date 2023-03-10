using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetOrders_ReturnsEmptyOrdersProperty_OrderList()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput);
      List<Vendor> newList = new List<Vendor> {};
      CollectionAssert.AreEqual(newList, newVendor.Orders);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfAllVendorObjects_VendorList()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput); 
      List<Vendor> vendorList = new List<Vendor> {newVendor};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(result, vendorList);
    }

    [TestMethod]
    public void GetId_ReturnsVendorIdProperty_Int()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput); 
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorBasedOnId_Vendor()
    {
      string nameInput = "Super Caffe";
      string descriptionInput = "Ordered 3 items";
      Vendor newVendor = new Vendor(nameInput, descriptionInput); 
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(result, newVendor);
    }
  }
}