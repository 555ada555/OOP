using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.Сart
{
    public class SubtractCommand : ICommand
    {
        private CartProduct product;
        public SubtractCommand(CartProduct prod)
        {
            product = prod;
        }
        public void Execute()
        {
            product.Subtract();
        }
    }
}
