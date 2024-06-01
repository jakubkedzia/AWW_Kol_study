using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;

namespace AWWW_Kol1.Controllers
{
	public class TagController : Controller
	{
		private readonly DataBase _dbContext;
		public TagController(DataBase dataBase)
		{
			_dbContext = dataBase;
		}
		public IActionResult Index()
		{
			ViewBag.Title = "Tagi";
			IList<Tag> tags = _dbContext.Tags.ToList();
			return View(tags);
		}
		public IActionResult Dodaj()
		{

			return View();
		}
		[HttpPost]
		public IActionResult DodajTag(Tag tags)
		{
			_dbContext.Tags.Add(tags);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");	
		}
	}
}
