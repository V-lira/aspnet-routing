<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Archive.aspx.cs" Inherits="WebApplication4.Pages.Archive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Архивчик</title>
    <style>
        body { font-family: "Segoe UI", Tahoma, Arial, sans-serif; margin: 20px; color: #2c3e50; }
        .card { max-width: 600px; padding: 20px 24px; border: 1px solid #dde3ea; border-radius: 8px; background: #fff; }
        h2 { margin: 0 0 16px; }
        ul { padding-left: 20px; }
        .row { padding: 6px 0; }
        .label { display: inline-block; min-width: 100px; font-weight: 600; color: #56657a; }
        .err { color: #a94442; background: #fdecea; border: 1px solid #f5c6cb; padding: 10px 14px; border-radius: 5px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2>Архив материалов</h2>
            <asp:Panel ID="pnlInfo" runat="server" Visible="false">
                <div class="row"><span class="label">Год:</span> <asp:Literal ID="litYear" runat="server" /></div>
                <div class="row"><span class="label">Месяц:</span> <asp:Literal ID="litMonth" runat="server" /></div>
                <h3>Материалы:</h3>
                <asp:BulletedList ID="blMaterials" runat="server" />
            </asp:Panel>
            <asp:Panel ID="pnlError" runat="server" Visible="false" CssClass="err">
                <asp:Literal ID="litError" runat="server" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>