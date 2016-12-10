namespace DesignPatterns.Builder
{
    class ConcreteBuilder1 : IBuilder
    {
        private Product m_product;

        public ConcreteBuilder1()
        {
            m_product = new Product();
            m_product.Type = "Concrete Builder 1 Product";
        }

        public Product Product
        {
            get
            {
                return m_product;
            }
        }

        public void BuildPart1()
        {
            m_product.PART1 = Part1.PART1_1;
        }

        public void BuildPart2()
        {
            m_product.PART2 = Part2.PART2_1;
        }

        public void BuildPart3()
        {
            m_product.PART3 = Part3.PART3_1;
        }
    }

    class ConcreteBuilder2 : IBuilder
    {
        private Product m_product;

        public ConcreteBuilder2()
        {
            m_product = new Product();
            m_product.Type = "Concrete Builder 2 Product";
        }

        public Product Product
        {
            get
            {
                return m_product;
            }
        }

        public void BuildPart1()
        {
            m_product.PART1 = Part1.PART1_2;
        }

        public void BuildPart2()
        {
            m_product.PART2 = Part2.PART2_2;
        }

        public void BuildPart3()
        {
            m_product.PART3 = Part3.PART3_2;
        }
    }
}
