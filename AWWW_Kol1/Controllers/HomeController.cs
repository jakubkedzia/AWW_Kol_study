using Microsoft.AspNetCore.Mvc;

namespace AWWW_Kol1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			@ViewBag.Title = "Strona glowna";
			return View();
		}
	}
}
