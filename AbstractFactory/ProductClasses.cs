namespace DesignPatterns.AbstractFactory
{
    class ConcreteProductA1 : IProductA
    {
        internal ConcreteProductA1() { }
        public string Name { get { return "Concrete product A1"; } }
    }

    class ConcreteProductA2 : IProductA
    {
        internal ConcreteProductA2() { }
        public string Name { get { return "Concrete product A2"; } }
    }

    class ConcreteProductB1 : IProductB
    {
        internal ConcreteProductB1() { }
        public string Name { get { return "Concrete product B1"; } }
    }

    class ConcreteProductB2 : IProductB
    {
        internal ConcreteProductB2() { }
        public string Name { get { return "Concrete product B2"; } }
    }

    class ConcreteProductC1 : IProductC
    {
        internal ConcreteProductC1() { }
        public string Name { get { return "Concrete product C1"; } }
    }

    class ConcreteProductC2 : IProductC
    {
        internal ConcreteProductC2() { }
        public string Name { get { return "Concrete product C2"; } }
    }
}
