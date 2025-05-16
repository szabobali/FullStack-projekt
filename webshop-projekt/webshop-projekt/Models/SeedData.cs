using Microsoft.EntityFrameworkCore;
using webshop_projekt.DAL;

namespace webshop_projekt.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            WebshopDbContext context = app.ApplicationServices.CreateScope().
            ServiceProvider.GetRequiredService<WebshopDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Name = "processzor" },
                    new Category { Name = "alaplap" },
                    new Category { Name = "tápegység" }
                );
                context.SaveChanges(); // FONTOS!
            }

            if (!context.Goods.Any())
            {
                context.Goods.AddRange(
                    new Goods
                    {
                        Name = "Atomic Habits",
                        Description = "An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                        Category = context.Categories.First(c => c.Name == "processzor"),
                        Price = 11.98m
                    },
                    new Goods
                    {
                        Name = "How to Win Friends & Influence People",
                        Description = "You can go after the job you want...and get it!",
                        Category = context.Categories.First(c => c.Name == "processzor"),
                        Price = 17.46m
                    },
                    new Goods
                    {
                        Name = "Rich Dad Poor Dad",
                        Description = "What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not!",
                        Category = context.Categories.First(c => c.Name == "alaplap"),
                        Price = 13.41m
                    },
                    new Goods
                    {
                        Name = "The Psychology of Money",
                        Description = "Doing well with money isn’t necessarily about what you know...",
                        Category = context.Categories.First(c => c.Name == "alaplap"),
                        Price = 18.69m
                    },
                    new Goods
                    {
                        Name = "48 Laws of Power",
                        Description = "Amoral, cunning, ruthless... distills 3000 years of the history of power.",
                        Category = context.Categories.First(c => c.Name == "tápegység"),
                        Price = 31.26m
                    });
                context.SaveChanges();
            }

        }
    }
}
