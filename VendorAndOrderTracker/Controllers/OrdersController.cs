using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }   

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Destroy(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      vendor.Orders.Remove(order);
      return RedirectToAction("Show", "Vendors", vendor);
    }

  } 
}