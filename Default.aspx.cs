using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lnkS1.NavigateUrl = GetRouteUrl("StudentsRoute", new { id = 1 });
            lnkS2.NavigateUrl = GetRouteUrl("StudentsRoute", new { id = 2 });
            lnkS25.NavigateUrl = GetRouteUrl("StudentsRoute", new { id = 25 });
            lnkS100.NavigateUrl = GetRouteUrl("StudentsRoute", new { id = 100 });
            lnkS999.NavigateUrl = GetRouteUrl("StudentsRoute", new { id = 999 });

            lnkAllProducts.NavigateUrl = GetRouteUrl("ProductsRoute", null);
            lnkP3.NavigateUrl = GetRouteUrl("ProductRoute", new { id = 3 });
            lnkP8.NavigateUrl = GetRouteUrl("ProductRoute", new { id = 8 });
            lnkNewProduct.NavigateUrl = GetRouteUrl("NewProductRoute", null);

            lnkCatLaptops.NavigateUrl = GetRouteUrl("CatalogListRoute", new { category = "laptops" });
            lnkCatPhones.NavigateUrl = GetRouteUrl("CatalogListRoute", new { category = "phones" });
            lnkCatAudio.NavigateUrl = GetRouteUrl("CatalogListRoute", new { category = "audio" });
            lnkCatItem.NavigateUrl = GetRouteUrl("CatalogItemRoute", new { category = "laptops", id = 4 });

            lnkArch1.NavigateUrl = GetRouteUrl("ArchiveRoute", new { year = 2026, month = "09" });
            lnkArch2.NavigateUrl = GetRouteUrl("ArchiveRoute", new { year = 2025, month = "12" });

            lnkBooks.NavigateUrl = GetRouteUrl("BooksRoute", null);
            lnkBook1.NavigateUrl = GetRouteUrl("BookRoute", new { id = 1 });
            lnkAuthor.NavigateUrl = GetRouteUrl("AuthorRoute", new { name = "камень" });
            lnkGenre.NavigateUrl = GetRouteUrl("GenreRoute", new { name = "Фэнтези" });
        }
    }
}