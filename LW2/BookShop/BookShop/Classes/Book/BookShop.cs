using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes.Book
{
    public class BookShop
    {
        private List<Book> books = new List<Book>();

        // Додати книгу в магазин
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Отримати список всіх книг у магазині
        public List<Book> GetAllBooks()
        {
            List<Book> clonedBooks = new List<Book>();

            foreach (var book in books)
            {
                clonedBooks.Add((Book)book.Clone());
            }

            return clonedBooks;
        }
    }
}
