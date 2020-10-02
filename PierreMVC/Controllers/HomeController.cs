using Microsoft.AspNetCore.Mvc;

namespace PierreMVC.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet ("/")]
    public ActionResult Index()
    {
      return View ();
    }
  }
}