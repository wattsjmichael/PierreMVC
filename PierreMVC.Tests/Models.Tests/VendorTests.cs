using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreMVC.Models;
using System.Collections.Generic;
using System;

namespace PierreMVC.Tests
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sal's Deli");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}