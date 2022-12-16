using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public DateTime Date {get; set;}
    public int Id {get;}

    private static List<Order> _allOrders = new List<Order>{};

    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _allOrders.Add(this);
      Id = _allOrders.Count;
    }

    public static List<Order> GetAll()
    {
      return _allOrders;
    }

    public static void ClearAll()
    {
      _allOrders.Clear();
    }

    public static Order Find(int id)
    {
      return _allOrders[id - 1];
    }
  }
}