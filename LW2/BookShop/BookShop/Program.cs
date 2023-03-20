/*
Технічне завдання:
Магазин книг:
-Вибір способу оплати (патерн Фабричний метод)
Оплату можна здійснити:
    Переказом банківським
    Кредитною карткою
    PayPal
-Вибір способу доставки (патерн Абстрактна фабрика)
    Нова пошта:
        Курєрська
        Відділення
        Поштомат
    Укрпошта:
        Курєрська
        Відділення
-Реалізація покупки (патерн Прототип)
    Створення обєкта для покупки де буде визначино кількість замовлених книг клієнтів
-Реалізація створення клієнта (патерн Будівельник)
    Можливість введення даних для індентифікації користувача


// Створюємо об'єкт способу оплати кредитною карткою
using BookShop.Classes;
using BookShop.Classes.Payment;
using BookShop.Classes.Payment.FactoryDesignPattern;

PaymentMethod creditCardPayment = PaymentMethodFactory.CreatePaymentMethod("CreditCard", new string[] { "1234 5678 9012 3456", "12/23", "123" });
creditCardPayment.ProcessPayment(100.50);

// Створюємо об'єкт способу оплати через PayPal
PaymentMethod payPalPayment = PaymentMethodFactory.CreatePaymentMethod("PayPal", new string[] { "example@example.com", "password" });
payPalPayment.ProcessPayment(75.25);

// Створюємо об'єкт способу оплати банківським переказом
PaymentMethod bankTransferPayment = PaymentMethodFactory.CreatePaymentMethod("BankTransfer", new string[] { "1234567890", "1234" });
bankTransferPayment.ProcessPayment(50.75);


            Book existingBook = new Book("The Great Gatsby","F. Scott Fitzgerald",192);

            // Клонуємо існуючу книгу
            Book newBook = (Book)existingBook.Clone();

            newBook.Title = "The Catcher in the Rye";
*/

using BookShop.Classes.Payment;
using BookShop.Classes;

using System;
using System.Collections.Generic;
using BookShop.Classes.Payment.FactoryDesignPattern;
using BookShop.Classes.Delivery;
using BookShop.Classes.Client;

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

            // Створюємо перелік доступних книг
            List<Book> books = new List<Book>()
            {
                new Book("Лісова пісня", "Леся Українка", 100.50, 15),
                new Book("Золотий жук", "Едгар Алан По", 75.25, 15),
                new Book("1408", "Стівен Кінг", 50.75, 15),
        };

            // Виводимо на екран перелік доступних книг
            Console.WriteLine("Доступні книги:");
            foreach (Book book in books)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", book.Title, book.Author, book.Price, book.Count);
            }

            // Покупець обирає книгу та вводить інформацію про спосіб оплати
            Console.WriteLine("\nОберіть книгу (введіть номер):");
            int selectedBookIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("\nВведіть кількість примірників:");
            int selBookCount = int.Parse(Console.ReadLine()) - 1;


            Console.WriteLine("Оберіть спосіб оплати:");
            Console.WriteLine("1. Кредитна картка");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Банківський переказ");

            int selectedPaymentMethodIndex = int.Parse(Console.ReadLine());

            // Створюємо клон книги, яку купують за допомогою патерна Прототип
            Book selectedBook = (Book)books[selectedBookIndex].Clone();
            selectedBook.Count = selBookCount;

            books[selectedBookIndex].Count = books[selectedBookIndex].Count - selBookCount-1;

            // Створюємо об'єкт способу оплати, використовуючи фабричний метод
            PaymentMethod paymentMethod = PaymentMethodFactory.CreatePaymentMethod(selectedPaymentMethodIndex);
                   

            // Оплачуємо книгу, використовуючи обраний спосіб оплати
            double total = selectedBook.Price;
            Console.WriteLine("\nСума до сплати: {0}$", total);

            paymentMethod.ProcessPayment(total);

            Console.WriteLine("Книга \"{0}\" ({1}) успішно придбана!", selectedBook.Title, selectedBook.Author);


            Console.WriteLine("Доступні книги:");
            foreach (Book book in books)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", book.Title, book.Author, book.Price, book.Count);
            }

            Console.WriteLine("Оберіть спосіб доставки:");
            Console.WriteLine("1. Нова пошта");
            Console.WriteLine("2. Укрпошта");

            
            int selectedDeliveryIndex = int.Parse(Console.ReadLine());
            //Ада не забудь це КОРТЕЖ
            var result = DeliveryFactory.CreateDeliveryFactory(selectedDeliveryIndex);
            DeliveryFactory deliveryFactory = result.Item1;

            Delivery deliveryF = deliveryFactory.GetDelivery(result.Item2);

        }
    }
}
