using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set;}
    public string Description { get; set;}
    public int Id {get;}
    public List<Order> Orders { get; set;}

    private static List<Vendor> _allVendors = new List<Vendor>{};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      _allVendors.Add(this);
      Id = _allVendors.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }

    public static Vendor Find(int id)
    {
      return _allVendors[id -1];
    }
  }
}