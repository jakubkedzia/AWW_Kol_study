using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;

namespace AWWW_Kol1.Controllers
{
	public class ArticleController : Controller
	{
		public IActionResult Index(int id=1)
		{
			// tutaj zostaje stworzony nowy obiekt typu article
			var articles = new List<Article>()
			{
				new Article
				{
				ArticleId = 1,
				Title = "Artykuł 1",
				Content = "Dane arykulu 1 powiedzmy",
				CreationDate = DateTime.Now,
				},
				new Article
				{
					ArticleId=2,
					Title = "Artykul 2",
					Content = "Dane arykulu 2 powiedzmy",
					CreationDate = DateTime.Now
				},
				new Article
				{
					ArticleId=3,
					Title = "Artykul 3",
					Content = "Dane arykul 3 powiedzmy",
					CreationDate = DateTime.Now
				}
				
			};
			return View(articles[id-1]);
		}
	}
}
