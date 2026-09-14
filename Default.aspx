<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Лаба «Маршрутизация»</title>
    <style>
        body { font-family: "Segoe UI", Tahoma, Arial, sans-serif; margin: 20px; color: #2c3e50; background: #f7f9fc; }
        .card { max-width: 760px; margin: 0 auto; padding: 20px 28px; border: 1px solid #dde3ea; border-radius: 8px; background: #fff; }
        h2 { margin: 0 0 16px; font-size: 22px; }
        h3 { margin: 20px 0 8px; color: #56657a; font-size: 15px; border-bottom: 1px solid #e1e6ec; padding-bottom: 4px; }
        ul { padding-left: 22px; line-height: 1.9; margin: 0; }
        a { color: #2c3e50; text-decoration: none; }
        a:hover { text-decoration: underline; }
        .hint { color: #8b96a5; font-size: 12px; margin-left: 6px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2>Лаба «Маршрутизация»</h2>

            <h3>Задание 1. Студенты</h3>
            <ul>
                <li><asp:HyperLink ID="lnkS1" runat="server" Text="Вскодер Си Сишарпович" /></li>
                <li><asp:HyperLink ID="lnkS2" runat="server" Text="Джавович Сиплюсплюс Сичович" /></li>
                <li><asp:HyperLink ID="lnkS25" runat="server" Text="Сивович Сишарп Джавович" /></li>
                <li><asp:HyperLink ID="lnkS100" runat="server" Text="Скрипт Тайпскрипт Сишарпович" /></li>
                <li><asp:HyperLink ID="lnkS999" runat="server" Text="Несуществующий студент #999" /></li>
            </ul>

            <h3>Задание 2. Товары</h3>
            <ul>
                <li><asp:HyperLink ID="lnkAllProducts" runat="server" Text="Все товары (12 штук)" /></li>
                <li><asp:HyperLink ID="lnkP3" runat="server" Text="Айфон 15 Pro Max SE Mini Plus" /></li>
                <li><asp:HyperLink ID="lnkP8" runat="server" Text="Монитор 4K, но 720p" /></li>
                <li><asp:HyperLink ID="lnkNewProduct" runat="server" Text="Создать товар (products/new)" /></li>
            </ul>

            <h3>Задание 3. Категории</h3>
            <ul>
                <li><asp:HyperLink ID="lnkCatLaptops" runat="server" Text="Ноутбуки (laptops)" /></li>
                <li><asp:HyperLink ID="lnkCatPhones" runat="server" Text="Телефоны (phones)" /></li>
                <li><asp:HyperLink ID="lnkCatAudio" runat="server" Text="Аудио (audio)" /></li>
                <li><asp:HyperLink ID="lnkCatItem" runat="server" Text="Ноутбук Lenovo Asus VivoBook HP (laptops/4)" /></li>
            </ul>

            <h3>Задание 4. Архив</h3>
            <ul>
                <li><asp:HyperLink ID="lnkArch1" runat="server" Text="Архив 2026/09" /></li>
                <li><asp:HyperLink ID="lnkArch2" runat="server" Text="Архив 2025/12" /></li>
            </ul>

            <h3>Итоговое задание. Библиотека</h3>
            <ul>
                <li><asp:HyperLink ID="lnkBooks" runat="server" Text="Все книги (10 штук)" /></li>
                <li><asp:HyperLink ID="lnkBook1" runat="server" Text="Наруто в погоне за ветром" /></li>
                <li><asp:HyperLink ID="lnkAuthor" runat="server" Text="Автор: камень" /></li>
                <li><asp:HyperLink ID="lnkGenre" runat="server" Text="Жанр: Фэнтези" /></li>
            </ul>
        </div>
    </form>
</body>
</html>