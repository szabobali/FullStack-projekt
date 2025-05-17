using webshop_projekt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace webshop_projekt.DAL
{
    public class WebshopDbContext : IdentityDbContext<IdentityUser>
    {
        public WebshopDbContext(DbContextOptions<WebshopDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string ADMIN_ID = "02174cf0-9412-4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2-42de-afbf-59kmkkmk72cf6";

            // szerepkör
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // admin felhasználó
            var appUser = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@admin.hu",
                EmailConfirmed = true,
                UserName = "admin@admin.hu",
                NormalizedUserName = "ADMIN@ADMIN.HU"
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Jelszo123$");

            builder.Entity<IdentityUser>().HasData(appUser);

            // összerendelés
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
