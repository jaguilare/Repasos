using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    // Concrete Creater
    public class StoreSaleFactoryLogic_1 : SaleFactory
    {

        private decimal _extra;

        public StoreSaleFactoryLogic_1(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSaleLogic_1(_extra);
        }
    }
}
