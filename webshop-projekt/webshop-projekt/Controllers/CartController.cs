using webshop_projekt.DAL;
using webshop_projekt.Models;
using Microsoft.AspNetCore.Mvc;

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