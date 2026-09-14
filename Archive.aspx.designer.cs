using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Pages
{
    public partial class Archive : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var year = RouteData.Values["year"] as string;
            var month = RouteData.Values["month"] as string;

            if (string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month))
            {
                ShowError("Не указаны год и месяц(((");
                return;
            }

            if (!int.TryParse(year, out int y) || !int.TryParse(month, out int m)
                || y < 1900 || y > 2100 || m < 1 || m > 12)
            {
                ShowError("Эй! Это некорректные параметры архива!!!!");
                return;
            }

            litYear.Text = y.ToString();
            litMonth.Text = m.ToString("D2");

            blMaterials.Items.Add($"это 1 за {m:D2}.{y}");
            blMaterials.Items.Add($"это 2 за {m:D2}.{y}");
            blMaterials.Items.Add($"это 3 за {m:D2}.{y}");

            pnlInfo.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}