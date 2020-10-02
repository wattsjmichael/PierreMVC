using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierreMVC.Models;

namespace PierreMVC.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet ("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View (allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      Return View;
    }
  }
}