using System.Collections.Generic;

namespace PierreMVC.Models
{
  public class Order
  {
    public string Description { get; set;}
    private static List<Order> _instances = new List<Order> {};

    public Order (string description)
    {
      Description = description;
      _instances.Add(this);
    }
  }
}