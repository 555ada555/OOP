using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public class TitleExpression : AbstractExpression
    {
        private readonly string _title;

        public TitleExpression(string title)
        {
            _title = title;
        }

        public override List<Book> Interpret(List<Book> books)
        {
            return books.Where(book => book.Title.Equals(_title)).ToList();
        }
    }
}
