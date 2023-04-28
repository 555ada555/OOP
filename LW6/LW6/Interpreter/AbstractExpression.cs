using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract List<Book> Interpret(List<Book> books);
    }
}
