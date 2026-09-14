using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Book : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var routeId = RouteData.Values["id"] as string;

            if (string.IsNullOrEmpty(routeId) || !int.TryParse(routeId, out int id))
            {
                ShowError("Некорректный айди у книги");
                return;
            }

            var book = LibraryData.GetBook(id);

            if (book == null)
            {
                ShowError("книга не найдена!");
                return;
            }

            litTitle.Text = Server.HtmlEncode(book.Title);
            litYear.Text = book.Year.ToString();
            litDesc.Text = Server.HtmlEncode(book.Description);

            lnkAuthor.Text = Server.HtmlEncode(book.Author);
            lnkAuthor.NavigateUrl = GetRouteUrl("AuthorRoute", new { name = book.Author });

            lnkGenre.Text = Server.HtmlEncode(book.Genre);
            lnkGenre.NavigateUrl = GetRouteUrl("GenreRoute", new { name = book.Genre });

            pnlInfo.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}