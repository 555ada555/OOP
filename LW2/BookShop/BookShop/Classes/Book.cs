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
        public double Count { get; set; } // Ціна

        public Book(string title, string author, double price, double count)
        {
            Title = title;
            Author = author;
            Price = price;
            Count = count;
        }


        public override string ToString()
        {
            return $"{Title} by {Author} - {Price:C}";
        }

        //Прототип (Prototype)
        public Book Clone()
        {
            // Клонуємо об'єкт
            return (Book)this.MemberwiseClone();
        }
    }
}
