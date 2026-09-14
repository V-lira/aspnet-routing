# aspnet-routing

Реализована маршрутизация на ASP.NET Web Forms с использованием System.Web.Routing

<img width="834" height="930" alt="image" src="https://github.com/user-attachments/assets/31be2424-7e22-4e01-b25f-1907f09d06fe" />


--------------------------------------------------

## Что реализовано

*Задание 1. Профиль студента*
Маршрут students/{id}, страница Student.aspx
Для заранее заданных id выводятся разные ФИО, группа и курс

<img width="325" height="48" alt="Без имени" src="https://github.com/user-attachments/assets/0b1dac4f-7f62-49cd-91a4-c7785282cc10" />

<img width="658" height="224" alt="image" src="https://github.com/user-attachments/assets/62b8154e-a5eb-4aa0-855f-70533abd056c" />


*Задание 2. Каталог товаров*
Маршруты products и products/{id}
Список из 12 товаров, у каждого- название, категория и цена
Название- ссылка на страницу товара.

<img width="1178" height="868" alt="image" src="https://github.com/user-attachments/assets/1a80f6df-ff40-4ceb-8e3a-cbce2a4afd03" />

<img width="1029" height="374" alt="image" src="https://github.com/user-attachments/assets/0d289b89-362a-400c-a5ef-a57018712769" />


*Задание 3. Категории*
Маршруты catalog/{category} и catalog/{category}/{id}
На странице категории — только товары этой категории.
Если товар существует, но в другой категории- адрес считается некорректным

<img width="653" height="256" alt="image" src="https://github.com/user-attachments/assets/4faadf50-2d28-432b-8299-640281e2448a" />

<img width="1186" height="379" alt="image" src="https://github.com/user-attachments/assets/0a944cc7-7dca-4e33-8288-06abca92cd7c" />

<img width="1187" height="368" alt="image" src="https://github.com/user-attachments/assets/456b838e-1de2-4a23-bc71-0621e694ccca" />

*Задание 4. Архив*
Маршрут archive/{year}/{month}
year- ровно 4 цифры, month -от 01 до 12
Некорректные URL не попадают на страницу

<img width="1039" height="498" alt="image" src="https://github.com/user-attachments/assets/d525ff9e-2787-481a-8c2e-7a5b44c287b2" />


*Итоговое задание. Библиотека*
Маршруты books, books/{id}, authors/{name}, genres/{name}
10 книг, 4 автора, 3 жанра. 
Страницы: Books.aspx, Book.aspx,
Author.aspx, Genre.aspx

<img width="1495" height="768" alt="image" src="https://github.com/user-attachments/assets/b502fcfe-b5d9-409a-b541-654236adf08c" />

<img width="1188" height="410" alt="image" src="https://github.com/user-attachments/assets/ede69132-d66d-42dc-9e53-30ce86e4ab4e" />


--------------------------------------------------
## Как передаётся id

Id приходит в страницу из URL через параметр маршрута и читается в code-behind через RouteData.Values["id"]

Например, при переходе по адресу /books/1 ASP.NET передаёт в страницу Book.aspx значение id = 1, страница находит в коллекции книгу с этим
идентификатором и выводит её название

--------------------------------------------------

## Стек

- ASP.NET Web Forms (.NET Framework 4.8)
- C#
- System.Web.Routing
- Visual Studio 2022
