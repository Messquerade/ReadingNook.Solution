using Microsoft.AspNetCore.Mvc;

namespace ReadingNook.Controllers
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