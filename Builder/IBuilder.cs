namespace DesignPatterns.Builder
{
    interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product Product { get; }
    }
}
