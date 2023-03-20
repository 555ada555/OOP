/*
Технічне завдання:
Магазин книг:
-Реалізація покупки (патерн Прототип)
    Створення обєкта для покупки де буде визначино кількість замовлених книг клієнтів
-Реалізація створення клієнта (патерн Будівельник)
    Можливість введення даних для індентифікації користувача
*/

using BookShop.Classes.Payment;
using BookShop.Classes;

using System;
using System.Collections.Generic;
using BookShop.Classes.Payment.FactoryDesignPattern;
using BookShop.Classes.Delivery;
using BookShop.Classes.Client;
using BookShop.Classes.Book;

namespace BookStore
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Патерн Будівельник
            Client client1;
            ClientDirector clientDirector = new ClientDirector();

            ClientBuilder cl = new ClientBuilder();
            client1 = clientDirector.MakeClient(cl);
            Console.WriteLine(client1.ShowBeverage());

            Console.WriteLine("Новий клієнт:"); 

            var clientBuilder = new ClientBuilder();
            clientBuilder.SetName("Ада");
            clientBuilder.SetEmail("ada@example.com");
            clientBuilder.SetAddress("123 Молодіжна Стріт");
            clientBuilder.SetPhoneNumber("555-1234");
            var client = clientBuilder.GetClient();
            Console.WriteLine(client.ShowBeverage());

            //////////////////////////////////////////////


            List<BookPrototype> bookLIST = new List<BookPrototype>()
            {
                new Book("Лісова пісня", "Леся Українка", 10050, 15),
                new Book("Золотий жук", "Едгар Алан По", 75.25, 15),
                new Book("1408", "Стівен Кінг", 50.75, 15),
            };

            BookPrototype emp4 = bookLIST[2].Clone();

            // Виводимо на екран перелік доступних книг
            Console.WriteLine("Доступні книги:");
            foreach (Book book in bookLIST)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", book.title, book.author, book.price, book.count);
            }

            // Покупець обирає книгу та вводить інформацію про спосіб оплати
            Console.WriteLine("\nОберіть книгу (введіть номер):");
            int selectedBookIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("\nВведіть кількість примірників:");
            int selBookCount = int.Parse(Console.ReadLine()) - 1;

            BookPrototype selectedBook = bookLIST[selectedBookIndex].Clone();

            bookLIST[selectedBookIndex].count = bookLIST[selectedBookIndex].count - selBookCount - 1;

            Console.WriteLine("Книга \"{0}\" ({1}) успішно придбана!", selectedBook.title, selectedBook.author);


            Console.WriteLine("Доступні книги:");
            foreach (Book book in bookLIST)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", book.title, book.author, book.price, book.count);
            }

        }
    }
}
