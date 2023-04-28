using LW6.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AuthorExpression : AbstractExpression
{
    private readonly string _author;

    public AuthorExpression(string author)
    {
        _author = author;
    }

    public override List<Book> Interpret(List<Book> books)
    {
        return books.Where(book => book.Author.Equals(_author)).ToList();
    }
}
