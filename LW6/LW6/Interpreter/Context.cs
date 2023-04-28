using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6.Interpreter
{
    public class Context
    {
        private readonly List<Book> _books;

        public Context(List<Book> books)
        {
            _books = books;
        }

        public List<Book> ExecuteQuery(string query)
        {
            var keywords = new Query(query).GetKeywords();
            var logicalOperator = new Query(query).GetLogicalOperator();
            AbstractExpression expression1 = null;
            AbstractExpression expression2 = null;

            for (var i = 0; i < keywords.Count; i++)
            {
                var keyword = keywords[i];

                if (keyword.StartsWith("title:"))
                {
                    expression1 = new TitleExpression(keyword.Substring(6));
                }
                else if (keyword.StartsWith("author:"))
                {
                    expression1 = new AuthorExpression(keyword.Substring(7));
                }
                else if (keyword.StartsWith("genre:"))
                {
                    expression1 = new GenreExpression(keyword.Substring(6));
                }
                //else if (keyword.StartsWith("year:"))
                //{
                //   expression1 = new YearExpression(int.Parse(keyword.Substring(5)));
                //}

                if (i == 0)
                {
                    expression2 = expression1;
                }
                else
                {
                    if (logicalOperator == "OR")
                    {
                        expression2 = new OrExpression(expression2, expression1);
                    }
                    else
                    {
                        expression2 = new AndExpression(expression2, expression1);
                    }
                }
            }
            if (expression2 == null)
            {
                return _books;
            }

            return expression2.Interpret(_books);
        }
    }

}
