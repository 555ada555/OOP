using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public class GenreExpression : AbstractExpression
    {
        private readonly string _genre;

        public GenreExpression(string genre)
        {
            _genre = genre;
        }

        public override List<Book> Interpret(List<Book> books)
        {
            return books.Where(book => book.Genre.Equals(_genre)).ToList();
        }
    }
}
