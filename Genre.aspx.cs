<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Genre.aspx.cs" Inherits="WebApplication4.Pages.Genre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Жанр</title>
    <style>
        body { font-family: "Segoe UI", Tahoma, Arial, sans-serif; margin: 20px; color: #2c3e50; }
        .card { max-width: 700px; padding: 20px 24px; border: 1px solid #dde3ea; border-radius: 8px; background: #fff; }
        h2 { margin: 0 0 16px; }
        ul { padding-left: 20px; }
        .err { color: #a94442; background: #fdecea; border: 1px solid #f5c6cb; padding: 10px 14px; border-radius: 5px; }
        a { color: #2c3e50; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2>Жанр: <asp:Literal ID="litGenre" runat="server" /></h2>
            <asp:Panel ID="pnlInfo" runat="server" Visible="false">
                <h3>Книги жанра:</h3>
                <asp:Repeater ID="rpBooks" runat="server">
                    <HeaderTemplate><ul></HeaderTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# GetRouteUrl("BookRoute", new { id = Eval("Id") }) %>'
                                Text='<%# Eval("Title") %>' />
                        </li>
                    </ItemTemplate>
                    <FooterTemplate></ul></FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
            <asp:Panel ID="pnlError" runat="server" Visible="false" CssClass="err">
                <asp:Literal ID="litError" runat="server" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>