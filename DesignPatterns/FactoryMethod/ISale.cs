using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
