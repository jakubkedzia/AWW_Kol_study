using Microsoft.AspNetCore.Mvc;
using AWWW_Kol1.Models;
namespace AWWW_Kol1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataBase _dbContext;
        public CategoryController(DataBase dataBase)
        {
            _dbContext = dataBase;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Kategorie";
            IList<Category> categories = _dbContext.Categories.ToList();
            return View(categories);
        }
        public IActionResult Dodaj()
        {
            ViewBag.Title = "Dodaj kategorie";
            return View();
        }
        [HttpPost]
        public IActionResult DodajKategorie(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
