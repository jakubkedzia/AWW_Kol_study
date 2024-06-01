using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;
namespace AWWW_Kol1.Controllers
{
	public class LeagueController : Controller
	{
		private readonly DataBase _dbContext;
		public LeagueController(DataBase database)
		{
			_dbContext = database;
		}
		public IActionResult Index()
		{
			IList<Leauge> leagues = _dbContext.Lauges.ToList();
			return View(leagues);
		}
		public IActionResult Dodaj()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DodajLige(Leauge leauge)
		{
			_dbContext.Lauges.Add(leauge);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
