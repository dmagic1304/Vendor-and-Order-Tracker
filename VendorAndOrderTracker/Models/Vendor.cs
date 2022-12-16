using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set;}
    public string Description { get; set;}
    public List<Vendor> Orders { get; set;}

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Vendor> {};
    }
    
  }
}