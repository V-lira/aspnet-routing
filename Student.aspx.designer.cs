using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public partial class Student : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var routeId = RouteData.Values["id"] as string;

            if (string.IsNullOrEmpty(routeId) || !int.TryParse(routeId, out int id) || id <= 0)
            {
                ShowError("некорректный айди у студента");
                return;
            }

            var student = LibraryData.GetStudent(id);

            if (student == null)
            {
                ShowError("нету такого");
                return;
            }

            litId.Text = student.Id.ToString();
            litName.Text = Server.HtmlEncode(student.FullName);
            litGroup.Text = Server.HtmlEncode(student.Group);
            litCourse.Text = student.Course.ToString();

            pnlInfo.Visible = true;
        }

        private void ShowError(string msg)
        {
            litError.Text = Server.HtmlEncode(msg);
            pnlError.Visible = true;
        }
    }
}