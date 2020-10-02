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
      string result =  newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetID_OrdersInstantiatewithId_Int()
    {
      string description = "turn right on Barbur";
      Order newOrder = new Order(description);

      int result = 12;
      Assert.AreEqual(1, result);
    }
  }

}