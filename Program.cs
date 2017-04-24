using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Lazy;
using DesignPatterns.DynamicVisitor;

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

            IBuilder builder1 = new ConcreteBuilder1();
            Console.WriteLine($"New Product created: {Manufacture.Construct(builder1)}");
            builder1 = new ConcreteBuilder2();
            Console.WriteLine($"New Product created: {Manufacture.Construct(builder1)}");

            Creator creator = new Creator();
            IProduct product;
            product = creator.GetProduct(PRODUCT.TYPE1);
            Console.WriteLine(product.Description);
            product = creator.GetProduct(PRODUCT.TYPE2);
            Console.WriteLine(product.Description);

            LazyObject.Get("first");
            LazyObject.Get("second");
            LazyObject.ShowAll();
            LazyObject.Get("third");
            LazyObject.Get("first");
            LazyObject.ShowAll();

            Person personClient = new Client() { FirstName = "Ivan", SecondName = "Ivanov", OrdersCount = 5 };
            Person personEmployee = new Employee() { FirstName = "Petr", SecondName = "Petrov", Salary = 1000 };
            ToStringVisitor visitor = new ToStringVisitor();
            Console.WriteLine(visitor.DynamicVisit(personClient));
            Console.WriteLine(visitor.DynamicVisit(personEmployee));

            Console.WriteLine("Complete");
            Console.ReadKey();
            
        }
    }
}
