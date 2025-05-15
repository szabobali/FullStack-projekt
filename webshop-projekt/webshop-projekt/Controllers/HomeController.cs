using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webshop_projekt.DAL;
using webshop_projekt.Models;

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

        public IActionResult Index()
        {
            Goods termek = new Goods()
            {
                Description="ez itt egy teszt", Price=22301
            };
            _dbContext.Goods.Add(termek);
            _dbContext.SaveChanges();
            return View(_dbContext.Goods);
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
