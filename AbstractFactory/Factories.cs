namespace DesignPatterns.AbstractFactory
{
    class Product1Factory : IFactory
    {
        public IProductA GetProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB GetProductB()
        {
            return new ConcreteProductB1();
        }

        public IProductC GetProductC()
        {
            return new ConcreteProductC1();
        }
    }

    class Product2Factory : IFactory
    {
        public IProductA GetProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB GetProductB()
        {
            return new ConcreteProductB2();
        }

        public IProductC GetProductC()
        {
            return new ConcreteProductC2();
        }
    }
}
