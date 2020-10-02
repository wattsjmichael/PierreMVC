using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreMVC.Models;

namespace PierreMVC.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose ()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Alpha");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }

}