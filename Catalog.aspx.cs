<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="WebApplication4.Pages.Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Каталогчек</title>
    <style>
        body { font-family: "Segoe UI", Tahoma, Arial, sans-serif; margin: 20px; color: #2c3e50; }
        .card { max-width: 700px; padding: 20px 24px; border: 1px solid #dde3ea; border-radius: 8px; background: #fff; }
        h2 { margin: 0 0 16px; }
        table { width: 100%; border-collapse: collapse; }
        th, td { border: 1px solid #e1e6ec; padding: 8px 10px; text-align: left; font-size: 14px; }
        th { background: #eef3f9; }
        .err { color: #a94442; background: #fdecea; border: 1px solid #f5c6cb; padding: 10px 14px; border-radius: 5px; }
        .row { padding: 6px 0; }
        .label { display: inline-block; min-width: 110px; font-weight: 600; color: #56657a; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2><asp:Literal ID="litTitle" runat="server" /></h2>

            <asp:Panel ID="pnlList" runat="server" Visible="false">
                <asp:Repeater ID="rpProducts" runat="server">
                    <HeaderTemplate>
                        <table><tr><th>Id</th><th>Название</th><th>Цена</th></tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td>
                                <asp:HyperLink runat="server"
                                    NavigateUrl='<%# GetRouteUrl("CatalogItemRoute", new { category = Eval("Category"), id = Eval("Id") }) %>'
                                    Text='<%# Eval("Name") %>' />
                            </td>
                            <td><%# Eval("Price", "{0:N0}") %> ₽</td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>
            </asp:Panel>

            <asp:Panel ID="pnlItem" runat="server" Visible="false">
                <div class="row"><span class="label">Название:</span> <asp:Literal ID="litName" runat="server" /></div>
                <div class="row"><span class="label">Категория:</span> <asp:Literal ID="litCategory" runat="server" /></div>
                <div class="row"><span class="label">Цена:</span> <asp:Literal ID="litPrice" runat="server" /></div>
                <div class="row"><span class="label">Описание:</span> <asp:Literal ID="litDesc" runat="server" /></div>
            </asp:Panel>

            <asp:Panel ID="pnlError" runat="server" Visible="false" CssClass="err">
                <asp:Literal ID="litError" runat="server" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>