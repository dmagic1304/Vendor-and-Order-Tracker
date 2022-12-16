using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set;}
    public string Description { get; set;}
    public List<Vendor> Orders { get; set;}

    private static List<Vendor> _allVendors = new List<Vendor>{};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Vendor> {};
      _allVendors.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }

  }
}