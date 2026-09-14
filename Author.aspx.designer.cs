using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Author : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = RouteData.Values["name"] as string;

            if (string.IsNullOrEmpty(name))
            {
                ShowError("тут автор не указан!");
                return;
            }

            var books = LibraryData.Books
                .Where(b => string.Equals(b.Author, name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (books.Count == 0)
            {
                ShowError("Такого нет");
                return;
            }

            litAuthor.Text = Server.HtmlEncode(name);
            rpBooks.DataSource = books;
            rpBooks.DataBind();
            pnlInfo.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}