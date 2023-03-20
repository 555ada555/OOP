using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Classes.Book
{
    public abstract class BookPrototype
    {
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public double count { get; set; }



        public abstract BookPrototype Clone();
        public abstract void ShowDetails();
    }
}
