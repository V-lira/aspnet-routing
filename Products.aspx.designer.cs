using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Products : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpProducts.DataSource = LibraryData.Products;
            rpProducts.DataBind();
        }
    }
}