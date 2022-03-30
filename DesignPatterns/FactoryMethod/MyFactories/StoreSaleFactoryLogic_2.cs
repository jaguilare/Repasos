using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.MyFactories
{
    public class StoreSaleFactoryLogic_2 : SaleFactory
    {

        private decimal _discount;

        public StoreSaleFactoryLogic_2(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new StoreSaleLogic_2(_discount);
        }
    }
}
