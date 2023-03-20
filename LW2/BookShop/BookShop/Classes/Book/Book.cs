using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes.Book
{
    public class Book : BookPrototype
    {
        public Book(string Title, string Author, double Price, double Count)
        {
            title = Title;
            author = Author;
            price = Price;
            count = Count;
        }
        public override BookPrototype Clone()
        {
            // Клонуємо книгу
            return (BookPrototype)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine($" Title:{this.title}, Author: {this.author}, Price: {this.price}\n");
        }
    }
}
