namespace DesignPatterns.FactoryMethod
{
    enum PRODUCT { TYPE1, TYPE2 }
    class Creator
    {
        public IProduct GetProduct(PRODUCT id)
        {
            if(id == PRODUCT.TYPE1)
            {
                return new Product1();
            }
            if(id == PRODUCT.TYPE2)
            {
                return new Product2();
            }
            return new DefaultProduct();
        }
    }
}
