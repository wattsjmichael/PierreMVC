using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreMVC.Models;

namespace PierreMVC.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Alpha");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Turn Right on Barbur";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetID_OrdersInstantiatewithId_Int()
    {
      string description = "turn right on Barbur";
      Order newOrder = new Order(description);


      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "Turn Left on Barbur";
      string description02 = "17 Bagels";

      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      
      Order result = new Order("12 Pastries");
      
      Assert.AreEqual(newOrder2, result);
    }
  }

}