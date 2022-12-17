using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(string orderTitle, string orderDescription, int orderPrice, DateTime orderDate, int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      vendor.Orders.Add(newOrder);
      return View("Show", vendor);
    }

    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Destroy(int vendorId)
    {      
      List<Vendor> allVendors = Vendor.GetAll();
      allVendors.RemoveAt(vendorId - 1);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/deleteall")]
    public ActionResult Destroy()
    {   
      Vendor.ClearAll();
      return RedirectToAction("Index", "Home");
    }
  }
}