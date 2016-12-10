using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public enum MANUFACTURES
    {
        PRODUCT1FACTORY, PRODUCT2FACTORY
    }
    public class AbstractFactoryClient
    {
        private IFactory m_factory;
        private MANUFACTURES manifacture;

        public AbstractFactoryClient(MANUFACTURES m)
        {
            manifacture = m;
        }

        public void ProductList()
        {
            switch (manifacture)
            {
                case MANUFACTURES.PRODUCT1FACTORY:
                    m_factory = new Product1Factory();
                    break;
                case MANUFACTURES.PRODUCT2FACTORY:
                    m_factory = new Product2Factory();
                    break;
            }
            Console.WriteLine($"{manifacture}: ProductA: {m_factory.GetProductA().Name} ProductB: {m_factory.GetProductB().Name} ProductC: {m_factory.GetProductC().Name}");
        }
    }
}
