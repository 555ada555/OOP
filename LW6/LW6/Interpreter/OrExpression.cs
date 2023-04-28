using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public class OrExpression : AbstractExpression
    {
        private readonly AbstractExpression _expression1;
        private readonly AbstractExpression _expression2;

        public OrExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override List<Book> Interpret(List<Book> books)
        {
            var result1 = _expression1.Interpret(books);
            var result2 = _expression2.Interpret(books);

            return result1.Union(result2).ToList();
        }
    }
}
