using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreMVC.Models;
using System.Collections.Generic;
using System;

namespace PierreMVC.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }


    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sal's Deli", "360-444-444");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Sal's Deli";
      string vendorPhoneNumber = "360-444-4444";
      Vendor newVendor = new Vendor(name, vendorPhoneNumber);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Sal's Deli";
      string vendorPhoneNumber = "360-444-4444";
      Vendor newVendor = new Vendor(name, vendorPhoneNumber);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Sal's Deli";
      string name02 = "Ritchies Diner";
      string vendorPhoneNumber = "360-444-4444";
      Vendor newVendor1 = new Vendor(name01,vendorPhoneNumber);
      Vendor newVendor2 = new Vendor(name02, vendorPhoneNumber);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Sal's Deli";
      string name02 = "Ritchies Diner";
      string vendorPhoneNumber = "360-444-4444";
      Vendor newVendor1 = new Vendor(name01, vendorPhoneNumber);
      Vendor newVendor2 = new Vendor(name02, vendorPhoneNumber);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderwithVendor_OrderList()
    {
      int price = 24;
      string description = "12 Bagels";
      string date = "2020-09-22";
      string contact = "Steve";
      Order newOrder = new Order(description, price, date, contact);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Sal's Diner";
      string vendorPhoneNumber = "360-444-4444";
      Vendor newVendor = new Vendor(name, vendorPhoneNumber);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}