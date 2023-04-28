using LW6.Interpreter;
using LW6.Mediator;

class Program
{
    static void Main(string[] args)
    {
        var books = new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Southern Gothic", Year = 1960 },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Year = 1813 },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Modernist", Year = 1925 },
            new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez", Genre = "Magic Realism", Year = 1967 }
        };

        var context = new Context(books);

        // Execute a query to find all books with "Mockingbird" in the title
        var query1 = "title: Mockingbird";
        var result1 = context.ExecuteQuery(query1);
        Console.WriteLine($"Results for query '{query1}':");
        PrintResults(result1);

        // Execute a query to find all books by Jane Austen or Gabriel Garcia Marquez
        var query2 = "author: Austen OR author: Garcia Marquez";
        var result2 = context.ExecuteQuery(query2);
        Console.WriteLine($"Results for query '{query2}':");
        PrintResults(result2);

        // Execute a query to find all books in the Romance genre published after 1800
        //var query3 = "genre: Romance AND year: >1800";
        //var result3 = context.ExecuteQuery(query3);
        //Console.WriteLine($"Results for query '{query3}':");
        //PrintResults(result3);

        // Створюємо об'єкти класів
        var mediator = new Mediator();
        var cart = new Cart(mediator);
        var creditCardPayment = new CreditCardPayment();
        var payPalPayment = new PayPalPayment();

        mediator.AddPayment(creditCardPayment);

        // Додаємо товари до корзини
        cart.AddProduct(new Product { Id = 1, Name = "Product 1", Price = 10 });
        cart.AddProduct(new Product { Id = 2, Name = "Product 2", Price = 20 });
        cart.AddProduct(new Product { Id = 3, Name = "Product 3", Price = 30 });

        // Оформляємо замовлення з платежем кредитною карткою
        cart.PlaceOrder(creditCardPayment);
    }

    static void PrintResults(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}, {book.Genre}, {book.Year}");
        }
        Console.WriteLine();
    }


}

