using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateOrderObjectInstance_Order()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleProperty_String()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Assert.AreEqual(titleInput, newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Assert.AreEqual(descriptionInput, newOrder.Description);
    }

    [TestMethod]
    public void GetTitle_ReturnsPriceProperty_Int()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Assert.AreEqual(priceInput, newOrder.Price);
    }

    [TestMethod]
    public void GetTitle_ReturnsDateProperty_DateTime()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Assert.AreEqual(dateInput, newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfAllOrderObjects_OrderList()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      List<Order> orderList = new List<Order>{newOrder};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(result, orderList);
    }

    [TestMethod]
    public void GetId_ReturnsOrderIdProperty_Int()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorBasedOnId_Vendor()
    {
      string titleInput = "Bread";
      string descriptionInput = "4 loafs of bread";
      int priceInput = 15;
      DateTime dateInput = new DateTime(2022, 12, 16);
      Order newOrder = new Order(titleInput, descriptionInput, priceInput, dateInput);
      Order result = Order.Find(1);
      Assert.AreEqual(result, newOrder);
    }
  }
}