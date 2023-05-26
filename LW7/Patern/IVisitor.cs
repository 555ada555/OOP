using System;
using System.Collections.Generic;
using System.Text;

namespace LW7.Patern
{
    interface IVisitor
    {
        void Visit(Order order);
    }
}
