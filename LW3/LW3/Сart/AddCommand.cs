using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LW3.Сart
{
    public class AddCommand : ICommand
    {
        private CartProduct product;
        public AddCommand(CartProduct prod)
        {
            product = prod;
        }
        public void Execute()
        {
            product.Add();
        }
    }
}
