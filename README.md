# Webshop Projekt

## Készítette

Szentesi Bálint(FKNQAH)
Szabó Balázs(O28IFJ)

Ez az ASP.NET Core MVC alapokon fejlesztett webshop alkalmazás lehetőséget biztosít termékek böngészésére, keresésére, kosárba helyezésére, valamint rendelések leadására. Az alkalmazás Identity-alapú bejelentkezést és szerepkörkezelést, valamint adminisztratív funkciókat is tartalmaz a rendelések menedzseléséhez.

## Technikai háttér

A projekt a következő technológiákra épül:

- ASP.NET Core 8.0 MVC
- Entity Framework Core (SQL Server adatbázis)
- ASP.NET Identity (felhasználó- és jogosultságkezelés)
- Bootstrap 5 és jQuery (frontend megjelenítéshez)
- Session-alapú kosárkezelés

## Fájlszerkezet és főbb komponensek

### Controllers

- **HomeController.cs** – Kezeli a főoldalt, a keresést, valamint statikus tartalmakat (pl. adatvédelmi oldal).
- **CartController.cs** – A kosár működéséért és a rendelés leadásáért felel. A `SessionHelper` segítségével a kosár tartalmát session-ben tárolja.
- **OverHandlingController.cs** – Rendelések megjelenítése és kezelése adminisztrátorok számára.

### Models

- **Goods.cs, Category.cs** – A termékek és azok kategóriáinak modelljei.
- **Order.cs, Item.cs** – Rendelések és a hozzájuk tartozó tételek reprezentációi.
- **ErrorViewModel.cs** – Hibakezeléshez használt nézetmodell.
- **SessionHelper.cs** – A kosárkezelés segédosztálya, session-ön keresztül tárolja a kosár adatait.
- **SeedData.cs** – Alapértelmezett adatok betöltése fejlesztési vagy tesztelési célokra.

### DAL (Data Access Layer)

- **WebshopDbContext.cs** – Az Entity Framework adatbáziskapcsolatért felelős kontextusosztálya, amely definiálja a DbSet-eket (táblák leképezése).

### Views

- **Home/** – A főoldal (`Index.cshtml`), keresési oldal (`Search.cshtml`) és egyéb nézetek.
- **Cart/** – A kosár tartalma (`Index.cshtml`), valamint két lépéses fizetési folyamat (`CheckOut.cshtml`, `Checkout2.cshtml`).
- **OrderHandling/** – Adminisztrátorok számára elérhető rendeléslista (`Index.cshtml`).
- **Shared/** – Közös nézetek, pl. _Layout.cshtml (az oldal váza), hibák, részleges nézetek (`_LoginPartial`, `GoodsTemplate` stb.).
- **Shared/Components/NavigationMenu/** – Egyedi ViewComponent a navigációs menü megjelenítéséhez.

### wwwroot

- **css/** – Stíluslapok, például a `site.css`.
- **js/** – Egyedi JavaScript fájlok (`site.js`).
- **lib/** – Külső könyvtárak, mint a Bootstrap és jQuery, valamint validációs script-ek.

### Konfiguráció és egyéb

- **appsettings.json** – Alkalmazás konfigurációja, köztük az adatbáziskapcsolat is.
- **Program.cs** – A teljes alkalmazás belépési pontja. Itt történik a szolgáltatások regisztrálása (kontrollerek, EF context, Identity, session stb.).
- **webshop-projekt.sln** – A Visual Studio megoldásfájl, amellyel a teljes projekt könnyedén megnyitható.

### Migrations

- Az `EF Core` migrációk segítenek az adatbázis séma automatikus frissítésében, verziókezelésében.

## Funkcionalitás összefoglaló

- Böngészhető terméklista és keresési funkció
- Kosár, amely session alapon működik
- Kétlépcsős rendelés leadási folyamat
- Felhasználói fiókregisztráció és bejelentkezés
- Adminisztrációs felület a rendelések átlátására
- Bootstrap alapú reszponzív felhasználói felület

## Fejlesztési információk

A projekt fejlesztéséhez Visual Studio 2022 vagy újabb ajánlott. A fejlesztés során külön figyelmet fordítottunk a kódtagoltságra, moduláris felépítésre és az MVC mintázat betartására.

Az `appsettings.json` fájlban megadott `WebshopConnection` kapcsolati stringet szükség szerint módosítani kell egy működő SQL Server példányhoz.

A `SeedData` osztály futtatásával alapértelmezett termékek és kategóriák tölthetők be a rendszerbe fejlesztési céllal.

## Cél

Ez a projekt oktatási célokat szolgál, de megfelelő továbbfejlesztéssel akár éles rendszer alapjául is szolgálhat. A célunk az volt, hogy egy jól strukturált, skálázható és bővíthető webshop-keretrendszert hozzunk létre, amely megfelel a mai webes fejlesztési alapelveknek.

### Github
https://github.com/szabobali/FullStack-projekt
