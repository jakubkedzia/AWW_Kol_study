using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;

namespace AWWW_Kol1.Controllers
{
	public class ArticleController : Controller
	{
		private readonly DataBase _dbContext;
		public ArticleController(DataBase dataBase)
		{
			this._dbContext = dataBase;
		}
		public IActionResult Index()
		{
			ViewBag.Title = "Articles";
			IList<Article> articles = _dbContext.Articles.ToList();
			return View(articles);
		}
		public IActionResult Dodaj()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DodajArtykul(Article article)
		{
			_dbContext.Articles.Add(article);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
