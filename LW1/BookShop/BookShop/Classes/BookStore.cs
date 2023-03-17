using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes
{
    public class BookStore
    {
        private List<Book> _books = new List<Book>(); // Список книг у магазині

        // Додати книгу до магазину
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // Видалити книгу з магазину
        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        // Пошук книг за назвою
        public List<Book> SearchByTitle(string title)
        {
            return _books.Where(book => book.Title.Contains(title)).ToList();
        }

        // Пошук книг за автором
        public List<Book> SearchByAuthor(string author)
        {
            return _books.Where(book => book.Author.Contains(author)).ToList();
        }

        // Пошук книг за ціною
        public List<Book> SearchByPrice(double price)
        {
            return _books.Where(book => book.Price == price).ToList();
        }

        // Отримати список всіх книг у магазині
        public List<Book> GetAllBooks()
        {
            return _books;
        }
    }
}
