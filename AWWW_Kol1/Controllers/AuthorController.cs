using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;

namespace AWWW_Kol1.Controllers
{
	public class AuthorController : Controller
	{
		private readonly DataBase _dbContext;
		public AuthorController(DataBase dataBase)
		{
			this._dbContext = dataBase;
		}
		public IActionResult Index()
		{
			ViewBag.Title = "Autorzy";
			IList<Author> authors = _dbContext.Authors.ToList();
			return View(authors);
		}
		public IActionResult Dodaj()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DodajAutora(Author author)
		{
			_dbContext.Authors.Add(author);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
