using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopManagementSystem.Abstraction
{
    public abstract class CheckoutProcess
    {
        public abstract void Checkout(List<Product> cart);
    }
}
