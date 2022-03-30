using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.MyFactories
{

    // Concret Product
    public class StoreSaleLogic_2 : ISale
    {

        private decimal _discount;


        public StoreSaleLogic_2(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta total menos el descuento es igual a ${total - _discount}");
        }
    }
}
