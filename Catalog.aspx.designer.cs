using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Catalog : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var category = RouteData.Values["category"] as string;
            var idRaw = RouteData.Values["id"] as string;

            if (string.IsNullOrEmpty(category))
            {
                ShowError("тут категории нет!");
                return;
            }

            if (string.IsNullOrEmpty(idRaw))
            {
                var list = LibraryData.Products.Where(p => p.Category == category).ToList();
                if (list.Count == 0)
                {
                    ShowError("эй, в этой категории нет товаров");
                    return;
                }

                litTitle.Text = "Категория: " + Server.HtmlEncode(category);
                rpProducts.DataSource = list;
                rpProducts.DataBind();
                pnlList.Visible = true;
                return;
            }

            if (!int.TryParse(idRaw, out int id))
            {
                ShowError("Некорректный айди у товара");
                return;
            }

            var product = LibraryData.GetProduct(id);

            if (product == null || product.Category != category)
            {
                ShowError("Товар не найден тута");
                return;
            }

            litTitle.Text = "товар в категории: " + Server.HtmlEncode(category);
            litName.Text = Server.HtmlEncode(product.Name);
            litCategory.Text = Server.HtmlEncode(product.Category);
            litPrice.Text = product.Price.ToString("N0") + " ₽";
            litDesc.Text = Server.HtmlEncode(product.Description);
            pnlItem.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}