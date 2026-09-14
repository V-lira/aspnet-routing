using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }

    public static class LibraryData
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Id = 1,  FullName = "Вскодер Си Сишарпович", Group = "П-21", Course = 3 },
            new Student { Id = 2,  FullName = "Джавович Сиплюсплюс Сичович", Group = "П-22", Course = 2 },
            new Student { Id = 25, FullName = "Сивович Сишарп Джавович", Group = "ИС-20", Course = 4 },
            new Student { Id = 100, FullName = "Скрипт Тайпскрипт Сишарпович", Group = "П-23", Course = 1 }
        };

        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Телефон Поко Ай Макс Про 17+ Ultra 5G", Category = "phones", Price = 14999m, Description = "6.7\", 12/512 ГБ, три камеры, две из которых не работают" },
            new Product { Id = 2, Name = "Смартфон Xiaomi Samsung A54 Redmi", Category = "phones", Price = 21999m, Description = "Собран из трёх телефонов. Работает как один" },
            new Product { Id = 3, Name = "Айфон 15 Pro Max SE Mini Plus", Category = "phones", Price = 89999m, Description = "Экран 4 дюйма, батарея 8 мАч, рамка из титана" },
            new Product { Id = 4, Name = "Ноутбук Lenovo Asus VivoBook HP", Category = "laptops", Price = 55999m, Description = "15.6\", 16 ГБ RAM, но только если сидеть близко к роутеру" },
            new Product { Id = 5, Name = "MacBook на Windows 11 Pro", Category = "laptops", Price = 120000m, Description = "Корпус от MacBook, внутри, а системник старый" },
            new Product { Id = 6, Name = "Игровой ноутбук для офиса", Category = "laptops", Price = 74999m, Description = "Тянет Excel на максималках. Кулер шумит как пылесос - это ли не радость?)" },
            new Product { Id = 7, Name = "Монитор по акции (разбитый)", Category = "monitors", Price = 999m, Description = "Трещина в правом верхнем углу. Цвета передаёт, но не те" },
            new Product { Id = 8, Name = "Монитор 4K, но 720p", Category = "monitors", Price = 17999m, Description = "Разрешение зависит от настроения" },
            new Product { Id = 9, Name = "Игровой монитор 240 Гц (по паспорту)", Category = "monitors", Price = 32999m, Description = "240 Гц только на заставке Windows" },
            new Product { Id = 10, Name = "Наушники Сони Вегас Про", Category = "audio", Price = 12999m, Description = "Шумоподавление отключает желание слушать музыку" },
            new Product { Id = 11, Name = "Колонка JBL Sony Marshall", Category = "audio", Price = 15999m, Description = "Бренд уточняется при распаковке" },
            new Product { Id = 12, Name = "Наушники AirPods Pro (проводные)", Category = "audio", Price = 3999m, Description = "Беспроводные только по названию" }
        };

        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1,Title = "Наруто в погоне за ветром", Author = "ФАН", Genre = "Фэнтези", Year = 1999, Description = "охаё" },
            new Book { Id = 2,Title = "камень говорит (он философский)", Author = "камень", Genre = "Фэнтези", Year = 2012, Description = "опаньки... аналог колобка?" },
            new Book { Id = 3, Title = "Если бы дали суперсилу, то...", Author = "РАзговорник", Genre = "Фэнтези", Year = 1954, Description = "а вот если так подумать...то можно и не подумать" },
            new Book { Id = 4, Title = "Придумайте сами", Author = "Не хочу", Genre = "Классика", Year = 2099, Description = "Ро том, как писателю лень (Обломов?)" },
            new Book { Id = 5, Title = "Как.... а никак", Author = "О простом на сложном", Genre = "Классика", Year = 869, Description = "12 часов чтения, 4 тома" },
            new Book { Id = 6, Title = "метро в метро", Author = "автор серии", Genre = "Легенда", Year = 2026, Description = "продолжение метро?!" },
            new Book { Id = 7, Title = "Без интернета: но с Wi-Fi", Author = "Великий, что его не знают", Genre = "Фантастика", Year = 1949, Description = "А что если инетрнет отключат.... а люди включат вайфай) (предупреждение: несуразный бред)" },
            new Book { Id = 8, Title = "восстание машин", Author = "эвм", Genre = "Фантастика", Year = 1945, Description = "короче туда сюда и опа, машины у руля" },
            new Book { Id = 9, Title = "как создать ... не придумали ещё", Author = "автор", Genre = "Мистика", Year = 1967, Description = "не придумали ещё" },
            new Book { Id = 10, Title = "туда и обратно, так сяк", Author = "обычный", Genre = "Фэнтези", Year = 1937, Description = "всё потеряно: и компас и карта и вера в выход из лабиринта" }
        };

        public static Student GetStudent(int id) => Students.FirstOrDefault(s => s.Id == id);
        public static Product GetProduct(int id) => Products.FirstOrDefault(p => p.Id == id);
        public static Book GetBook(int id) => Books.FirstOrDefault(b => b.Id == id);
    }
}