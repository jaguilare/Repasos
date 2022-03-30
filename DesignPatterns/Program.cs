using DesignPatterns.FactoryMethod;
using DesignPatterns.FactoryMethod.MyFactories;
using DesignPatterns.Singleton;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.MyStrategies;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ***** SINGLETON
            var log = Singleton.Log.Instance;
            log.Save("hola!");
            var a = Singleton.Log.Instance;
            var b = Singleton.Log.Instance;
            Console.WriteLine(a == b); // Es la misma instancia
            LogParams.GetInstance("log.txt").Save("hola singleton params");




            // https://dzone.com/articles/strategy-vs-factory-design-pattern-in-java
            // ***** FACTORY METHOD
            SaleFactory storeSaleFactoryLogic_1 = new StoreSaleFactoryLogic_1(10); // se envia el recargo
            SaleFactory storeSaleFactoryLogic_2 = new StoreSaleFactoryLogic_2(12); // se envia el descuento
            // metodo con logica 1 (recargo al total)
            ISale saleSurcharge = storeSaleFactoryLogic_1.GetSale();
            saleSurcharge.Sell(15); // se envia el subtotal
            // metodo con logica 2 (descuento al total)
            ISale saleDiscount = storeSaleFactoryLogic_2.GetSale();
            saleDiscount.Sell(10); // se envia el subtotal




            // ***** DEPENDENCY INJECTION
            // Inyeccion de dependencias en .Net Core
            // En la clase Service.cs
            // addTracient, addScope, addSingleton
            // Se inyecta en la clase a utilizar
            // mediante el constructor de dichas clase


            /*El patrón de estrategia se trata realmente de tener una implementación diferente que logre (básicamente) lo mismo, 
            de modo que una implementación pueda reemplazar a la otra según lo requiera la estrategia. 
            Por ejemplo, puede tener diferentes algoritmos de clasificación en un patrón de estrategia. 
            Las personas que llaman al objeto no cambian según la estrategia que se emplee, 
            pero independientemente de la estrategia, el objetivo es el mismo (ordenar la colección).*/

            // ***** STRATEGY 
            var context = new Context(new CarStrategy());
            context.Run();
            context.Strategy = new MotoStrategy();
            context.Run();



            /*El patrón de estado se trata de hacer diferentes cosas en función del estado, 
            dejando a la persona que llama aliviada de la carga de acomodar todos los estados posibles. 
            Entonces, por ejemplo, puede tener un getStatus()método que devolverá diferentes estados según el estado del objeto, 
            pero la persona que llama al método no tiene que codificarse de manera diferente para 
            tener en cuenta cada estado potencial.*/

            // ***** STATE
            // El funcionamiento y estado cambian de acuerdo a la logica de cada estado
            // Siempre se llama a Request, las reglas de negocio se aplican segun el estado
            var customerContext = new CustomerContext();
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());

        }
    }
}
