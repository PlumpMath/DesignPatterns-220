namespace DesignPatterns.FactoryMethod
{
    class Product1 : IProduct
    {
        public string Description
        {
            get
            {
                return "Product Type 1";
            }
        }
    }

    class Product2 : IProduct
    {
        public string Description
        {
            get
            {
                return "Product Type 2";
            }
        }
    }

    class DefaultProduct : IProduct
    {
        public string Description
        {
            get
            {
                return "default";
            }
        }
    }
}
