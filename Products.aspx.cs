<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebApplication4.Pages.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Каталочек</title>
    <style>
        body { font-family: "Segoe UI", Tahoma, Arial, sans-serif; margin: 20px; color: #2c3e50; }
        .card { max-width: 700px; padding: 20px 24px; border: 1px solid #dde3ea; border-radius: 8px; background: #fff; }
        h2 { margin: 0 0 16px; }
        table { width: 100%; border-collapse: collapse; }
        th, td { border: 1px solid #e1e6ec; padding: 8px 10px; text-align: left; font-size: 14px; }
        th { background: #eef3f9; }
        a { color: #2c3e50; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2>Каталог товаров</h2>
            <asp:Repeater ID="rpProducts" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr><th>Id</th><th>Название</th><th>Категория</th><th>Цена</th></tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td>
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# GetRouteUrl("ProductRoute", new { id = Eval("Id") }) %>'
                                Text='<%# Eval("Name") %>' />
                        </td>
                        <td><%# Server.HtmlEncode(Eval("Category").ToString()) %></td>
                        <td><%# Eval("Price", "{0:N0}") %> ₽</td>
                    </tr>

                </ItemTemplate>
                <FooterTemplate></table></FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
