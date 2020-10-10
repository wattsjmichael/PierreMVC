using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreMVC.Models;

namespace PierreMVC.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Alpha", 23, "2019-11-24", "Michael");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Turn Right on Barbur";
      int price = 24;
      string date = "2020-10-13";
      string contact = "Michael";
      Order newOrder = new Order(description, price, date, contact);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetID_OrdersInstantiatewithId_Int()
    {
      int price = 24;
      string date = "2020-10-13";
      string description = "turn right on Barbur";
      string contact = "Michael";
      Order newOrder = new Order(description, price, date, contact);


      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "Turn Left on Barbur";
      int price01 = 24;
      string date01 = "2020-10-13";
      string description02 = "17 Bagels";
      int price02 = 12;
      string date02 = "2020-11-13";
      string contact = "Gillian";


      Order newOrder1 = new Order(description01, price01, date01, contact);
      Order newOrder2 = new Order(description02, price02, date02, contact);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
    public void GetDeliveryDate_ReturnsDeliveryDate_String()
    {
      string date = "2020-11-23";
      int price = 24;
      string description = "Left on Barbur";
      string contact = "Stella";
      Order newOrder = new Order(description, price, date, contact);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    public void GetPrice_ReturnsPrice_Int()
    {
      string date = "2020-11-23";
      int price = 24;
      string description = "Left on Barbur";
      string contact = "Marla";
      Order newOrder = new Order(description, price, date, contact);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }


}