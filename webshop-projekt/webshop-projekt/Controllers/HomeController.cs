using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webshop_projekt.DAL;
using webshop_projekt.Models;
using Microsoft.EntityFrameworkCore;

namespace webshop_projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private WebshopDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, WebshopDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index(string category)
        {
            var goods = _dbContext.Goods.Where(x => category == null || x.Category.Name == category);
            ViewBag.SelectedCategory = category ?? "";
            return View(goods);
        }

        [HttpGet]
        public IActionResult Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return View(new List<Goods>());

            var results = _dbContext.Goods
                .Where(g => g.Name.Contains(query) || g.Description.Contains(query))
                .ToList();

            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
