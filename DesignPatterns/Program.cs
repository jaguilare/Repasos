using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SINGLETON
            var log = Singleton.Log.Instance;
            log.Save("hola!");
            var a = Singleton.Log.Instance;
            var b = Singleton.Log.Instance;
            Console.WriteLine(a == b);
            LogParams.GetInstance("log.txt").Save("hola singleton params");

            // FACTORY METHOD
            SaleFactory storeSaleFactoryLogic_1 = new StoreSaleFactoryLogic_1(10); // se envia el recargo
            SaleFactory storeSaleFactoryLogic_2 = new StoreSaleFactoryLogic_2(12); // se envia el descuento

            // metodo con logica 1 (recargo al total)
            ISale saleSurcharge = storeSaleFactoryLogic_1.GetSale();
            saleSurcharge.Sell(15); // se envia el total
            // metodo con logica 2 (descuento al total)
            ISale saleDiscount = storeSaleFactoryLogic_2.GetSale();
            saleDiscount.Sell(10); // se envia el total
        }
    }
}
