namespace DesignPatterns.DynamicVisitor
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
    public class Client : Person
    {
        public int OrdersCount { get; set; }
    }
    public class Employee : Person
    {
        public int Salary { get; set; }
    }
}
