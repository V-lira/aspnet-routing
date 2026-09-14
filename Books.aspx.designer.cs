using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Books : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpBooks.DataSource = LibraryData.Books;
            rpBooks.DataBind();
        }
    }
}