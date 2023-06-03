using Microsoft.AspNetCore.Mvc;

namespace furniture_shop.Controllers
{
  public class AboutUsController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
