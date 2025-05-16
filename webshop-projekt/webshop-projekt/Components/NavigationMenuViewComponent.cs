using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using webshop_projekt.DAL;

namespace webshop_projekt.Components
{
    public class NavigationMenuViewComponent :ViewComponent
    {
        private WebshopDbContext _dbContext;
        public NavigationMenuViewComponent(WebshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _dbContext.Goods.Select(x => x.Category).Distinct().OrderBy(x => x);
            return View(categories);
        }
    }
}
