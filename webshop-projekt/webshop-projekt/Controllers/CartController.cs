using webshop_projekt.DAL;
using webshop_projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace webshop_projekt.Controllers
{
    public class CartController : Controller
    {
        private WebshopDbContext _dbContext;
        public CartController(WebshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session,
            "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }
        [Route("buy/{id}")]
        public IActionResult Buy(long id)
        {
            List<Item>? cart =
            SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item { Product = _dbContext.Goods.Find(id), Quantity = 1 });
            }
            else
            {
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _dbContext.Goods.Find(id), Quantity = 1 });
                }
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        [Route("remove/{id}")]
        public IActionResult Remove(long id)
        {
            List<Item> cart =
            SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View("CheckOut");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut(Order order)
        {
            if (ModelState.IsValid)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                order.TotalPrice = (int)cart.Sum(item => item.Product.Price * item.Quantity);
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                HttpContext.Session.Clear(); // Kosár ürítése
                return View("CheckOut2", order);
            }
            return View("CheckOut");
        }
        private int IsExist(long id)
        {
            List<Item> cart =
            SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int i = 0;
            while (i < cart.Count && cart[i].Product.ID != id)
            {
                i++;
            }
            if (i < cart.Count) return i;
            else return -1;
        }
    }
}