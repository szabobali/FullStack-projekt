using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webshop_projekt.DAL;
using webshop_projekt.Models;

namespace webshop_projekt.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderHandlingController : Controller
    {
        private WebshopDbContext _dbContext;

        public OrderHandlingController(WebshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var orders = _dbContext.Orders.ToList();
            return View(orders);
        }
    }
}