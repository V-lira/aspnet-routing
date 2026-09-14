using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Product : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var routeId = RouteData.Values["id"] as string;

            if (string.IsNullOrEmpty(routeId) || !int.TryParse(routeId, out int id))
            {
                ShowError("Некорректный айди у товара");
                return;
            }

            var product = LibraryData.GetProduct(id);

            if (product == null)
            {
                ShowError("такого товара нету");
                return;
            }

            litName.Text = Server.HtmlEncode(product.Name);
            litCategory.Text = Server.HtmlEncode(product.Category);
            litPrice.Text = product.Price.ToString("N0") + " рубли";
            litDesc.Text = Server.HtmlEncode(product.Description);

            pnlInfo.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}