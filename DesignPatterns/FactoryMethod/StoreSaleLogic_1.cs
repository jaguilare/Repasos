using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    // Concret Product
    public class StoreSaleLogic_1 : ISale
    {

        private decimal _extra;

        public StoreSaleLogic_1(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en total mas el recargo es igual a ${total + _extra}");
        }
    }
}
