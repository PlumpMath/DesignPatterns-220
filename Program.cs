using System;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryClient client = new AbstractFactoryClient(MANUFACTURES.PRODUCT1FACTORY);
            client.ProductList();
            client = new AbstractFactoryClient(MANUFACTURES.PRODUCT2FACTORY);
            client.ProductList();


            Console.ReadKey();
        }
    }
}
