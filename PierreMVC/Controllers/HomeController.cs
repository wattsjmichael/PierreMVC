using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierreMVC.Models;

namespace PierreMVC.Controllers
{
  public class HomeController : Controller
 {
   [HttpGet("/")]
   public ActionResult Index()
   {
     return View();
   }
 }
}