using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes
{
    public class Book
    {
        public string Title { get; set; }  // Назва
        public string Author { get; set; } // Автор
        public double Price { get; set; } // Ціна

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - {Price:C}";
        }
    }
}
