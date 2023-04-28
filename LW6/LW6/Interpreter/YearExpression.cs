using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public class YearExpression : AbstractExpression
    {
        private readonly int _year;

        public YearExpression(int year)
        {
            _year = year;
        }

        public override List<Book> Interpret(List<Book> books)
        {
            return books.Where(book => book.Year == _year).ToList();
        }
    }
}
