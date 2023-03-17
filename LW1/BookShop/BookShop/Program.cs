/*

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
*/
using BookShop.Classes.Payment;
using BookShop.Classes;

using System;
using System.Collections.Generic;
using BookShop.Classes.Payment.FactoryDesignPattern;
using BookShop.Classes.Delivery;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо перелік доступних книг
            List<Book> books = new List<Book>()
            {
                new Book("Лісова пісня", "Леся Українка", 100.50),
                new Book("Золотий жук", "Едгар Алан По", 75.25),
                new Book("1408", "Стівен Кінг", 50.75),
            };

            // Виводимо на екран перелік доступних книг
            Console.WriteLine("Доступні книги:");
            foreach (Book book in books)
            {
                Console.WriteLine("{0} ({1}) - {2}$", book.Title, book.Author, book.Price);
            }

            // Покупець обирає книгу та вводить інформацію про спосіб оплати
            Console.WriteLine("\nОберіть книгу (введіть номер):");
            int selectedBookIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Оберіть спосіб оплати:");
            Console.WriteLine("1. Кредитна картка");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Банківський переказ");

            int selectedPaymentMethodIndex = int.Parse(Console.ReadLine());

            // Створюємо об'єкт книги, яку купують
            Book selectedBook = books[selectedBookIndex];

            // Створюємо об'єкт способу оплати, використовуючи фабричний метод
            PaymentMethod paymentMethod = PaymentMethodFactory.CreatePaymentMethod(selectedPaymentMethodIndex);
                   

            // Оплачуємо книгу, використовуючи обраний спосіб оплати
            double total = selectedBook.Price;
            Console.WriteLine("\nСума до сплати: {0}$", total);

            paymentMethod.ProcessPayment(total);

            Console.WriteLine("Книга \"{0}\" ({1}) успішно придбана!", selectedBook.Title, selectedBook.Author);


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
