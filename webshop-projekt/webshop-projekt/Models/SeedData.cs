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
                    new Category { Name = "Processzor" },
                    new Category { Name = "Alaplap" },
                    new Category { Name = "Memória" },
                    new Category { Name = "Ssd" },
                    new Category { Name = "Merevlemez" },
                    new Category { Name = "Videokártya" },
                    new Category { Name = "Cpu hűtő" },
                    new Category { Name = "Tápegység" },
                    new Category { Name = "Ház" },
                    new Category { Name = "Hűtés" },
                    new Category { Name = "Hálózati eszköz" },
                    new Category { Name = "Hangkártya" },
                    new Category { Name = "Digitalizáló kártya" },
                    new Category { Name = "Egér" },
                    new Category { Name = "Billentyűzet" },
                    new Category { Name = "Monitor" }
                );
                context.SaveChanges();
            }

            if (!context.Goods.Any())
            {
                context.Goods.AddRange(
                    new Goods
                    {
                        Name = "Intel Core i7-13700K",
                        Description = "16 magos, 24 szálas processzor kiváló teljesítménnyel játékhoz és munkához.",
                        Category = context.Categories.First(c => c.Name == "Processzor"),
                        Price = 169900m
                    },
                    new Goods
                    {
                        Name = "AMD Ryzen 5 7600X",
                        Description = "6 magos, 12 szálas processzor, ideális középkategóriás rendszerekhez.",
                        Category = context.Categories.First(c => c.Name == "Processzor"),
                        Price = 114900m
                    },
                    new Goods
                    {
                        Name = "ASUS ROG STRIX B650E-F",
                        Description = "Prémium ATX alaplap AMD Ryzen processzorokhoz, PCIe 5.0 támogatással.",
                        Category = context.Categories.First(c => c.Name == "alaplap"),
                        Price = 124900m
                    },
                    new Goods
                    {
                        Name = "MSI MAG B660M MORTAR",
                        Description = "Kompakt Micro ATX alaplap Intel 12. generációs processzorokhoz.",
                        Category = context.Categories.First(c => c.Name == "alaplap"),
                        Price = 89900m
                    },
                    new Goods
                    {
                        Name = "Corsair Vengeance DDR5 32GB",
                        Description = "Gyors 32GB (2x16GB) DDR5 RAM készlet, 6000MHz sebességgel.",
                        Category = context.Categories.First(c => c.Name == "memória"),
                        Price = 51900m
                    },
                    new Goods
                    {
                        Name = "Kingston FURY Beast 16GB DDR4",
                        Description = "Megbízható 16GB DDR4 RAM, 3200MHz sebességgel.",
                        Category = context.Categories.First(c => c.Name == "memória"),
                        Price = 13800m
                    },
                    new Goods
                    {
                        Name = "Samsung 980 Pro 1TB NVMe SSD",
                        Description = "Nagy sebességű PCIe Gen4 NVMe M.2 SSD, 1TB kapacitással.",
                        Category = context.Categories.First(c => c.Name == "ssd"),
                        Price = 49900m
                    },
                    new Goods
                    {
                        Name = "Kingston A2000 500GB NVMe",
                        Description = "Megbízható és gyors PCIe 3.0 SSD mindennapi használatra.",
                        Category = context.Categories.First(c => c.Name == "ssd"),
                        Price = 22900m
                    },
                    new Goods
                    {
                        Name = "Seagate Barracuda 2TB HDD",
                        Description = "Megbízható 7200RPM merevlemez 2TB tárhellyel.",
                        Category = context.Categories.First(c => c.Name == "merevlemez"),
                        Price = 23400m
                    },
                    new Goods
                    {
                        Name = "Western Digital Blue 1TB",
                        Description = "Megbízható 1TB 7200RPM HDD asztali számítógépekhez.",
                        Category = context.Categories.First(c => c.Name == "merevlemez"),
                        Price = 18900m
                    },
                    new Goods
                    {
                        Name = "ASUS GeForce RTX 4070 Ti",
                        Description = "Erőteljes grafikus kártya ray tracing és DLSS 3 támogatással.",
                        Category = context.Categories.First(c => c.Name == "videokártya"),
                        Price = 349900m
                    },
                    new Goods
                    {
                        Name = "MSI Radeon RX 6750 XT",
                        Description = "AMD grafikus kártya 1440p játékhoz, kiváló teljesítménnyel.",
                        Category = context.Categories.First(c => c.Name == "videokártya"),
                        Price = 219900m
                    },
                    new Goods
                    {
                        Name = "Cooler Master Hyper 212 Black",
                        Description = "Hatékony és megfizethető CPU léghűtő.",
                        Category = context.Categories.First(c => c.Name == "cpu hűtő"),
                        Price = 12390m
                    },
                    new Goods
                    {
                        Name = "Noctua NH-D15",
                        Description = "Prémium dupla torony CPU hűtő csendes működéssel.",
                        Category = context.Categories.First(c => c.Name == "cpu hűtő"),
                        Price = 39900m
                    },
                    new Goods
                    {
                        Name = "Corsair RM750x 750W",
                        Description = "Teljesen moduláris, 80+ Gold minősítésű tápegység.",
                        Category = context.Categories.First(c => c.Name == "tápegység"),
                        Price = 43900m
                    },
                    new Goods
                    {
                        Name = "Seasonic Focus GX-650",
                        Description = "650W moduláris tápegység csendes működéssel.",
                        Category = context.Categories.First(c => c.Name == "tápegység"),
                        Price = 38900m
                    },
                    new Goods
                    {
                        Name = "NZXT H510",
                        Description = "Minimalista közepes toronyház edzett üveg oldallappal.",
                        Category = context.Categories.First(c => c.Name == "ház"),
                        Price = 29900m
                    },
                    new Goods
                    {
                        Name = "Fractal Design Meshify C",
                        Description = "Kiváló légáramlású közepes toronyház hálós előlappal.",
                        Category = context.Categories.First(c => c.Name == "ház"),
                        Price = 34900m
                    },
                    new Goods
                    {
                        Name = "Arctic P12 PWM Fan",
                        Description = "120mm-es házhűtő ventilátor PWM vezérléssel.",
                        Category = context.Categories.First(c => c.Name == "hűtés"),
                        Price = 3890m
                    },
                    new Goods
                    {
                        Name = "be quiet! Silent Wings 3",
                        Description = "Prémium csendes 140mm-es házhűtő ventilátor.",
                        Category = context.Categories.First(c => c.Name == "hűtés"),
                        Price = 8990m
                    },
                    new Goods
                    {
                        Name = "TP-Link Archer T4U",
                        Description = "USB Wi-Fi adapter kétsávos támogatással.",
                        Category = context.Categories.First(c => c.Name == "hálózati eszköz"),
                        Price = 9990m
                    },
                    new Goods
                    {
                        Name = "Intel Wi-Fi 6 AX200",
                        Description = "Belső Wi-Fi 6 modul asztali számítógépekhez.",
                        Category = context.Categories.First(c => c.Name == "hálózati eszköz"),
                        Price = 7990m
                    },
                    new Goods
                    {
                        Name = "ASUS Xonar SE",
                        Description = "PCIe hangkártya 5.1 csatornás támogatással.",
                        Category = context.Categories.First(c => c.Name == "hangkártya"),
                        Price = 15900m
                    },
                    new Goods
                    {
                        Name = "Creative Sound Blaster Audigy FX",
                        Description = "Megfizethető hangkártya a jobb hangzásért.",
                        Category = context.Categories.First(c => c.Name == "hangkártya"),
                        Price = 13900m
                    },
                    new Goods
                    {
                        Name = "Elgato HD60 X",
                        Description = "Külső rögzítőkártya játékfelvételekhez.",
                        Category = context.Categories.First(c => c.Name == "digitalizáló kártya"),
                        Price = 69900m
                    },
                    new Goods
                    {
                        Name = "AverMedia Live Gamer Mini",
                        Description = "Kompakt USB rögzítőkártya streameléshez.",
                        Category = context.Categories.First(c => c.Name == "digitalizáló kártya"),
                        Price = 42900m
                    },
                    new Goods
                    {
                        Name = "Logitech MX Master 3S",
                        Description = "Nagy pontosságú ergonomikus vezeték nélküli egér.",
                        Category = context.Categories.First(c => c.Name == "egér"),
                        Price = 34900m
                    },
                    new Goods
                    {
                        Name = "SteelSeries Apex 5",
                        Description = "Hibrid mechanikus RGB gamer billentyűzet.",
                        Category = context.Categories.First(c => c.Name == "billentyűzet"),
                        Price = 29900m
                    },
                    new Goods
                    {
                        Name = "Samsung Odyssey G5 27\"",
                        Description = "144Hz-es ívelt gamer monitor QHD felbontással.",
                        Category = context.Categories.First(c => c.Name == "monitor"),
                        Price = 99900m
                    },
                    new Goods
                    {
                        Name = "Dell UltraSharp U2723QE",
                        Description = "4K IPS monitor USB-C hubbal a produktivitásért.",
                        Category = context.Categories.First(c => c.Name == "monitor"),
                        Price = 189900m
                    });
                context.SaveChanges();
            }

        }
    }
}
