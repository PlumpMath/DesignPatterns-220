namespace DesignPatterns.DynamicVisitor
{
    public abstract class PersonVisitor<T>
    {
        public T DynamicVisit(Person p) { return Visit((dynamic)p); }

        protected abstract T Visit(Client cl);
        protected abstract T Visit(Employee emp);
    }

    public class ToStringVisitor : PersonVisitor<string>
    {
        protected override string Visit(Client cl)
        {
            return $"First Name : {cl.FirstName} Second Name: {cl.SecondName} Order Count: {cl.OrdersCount}";
        }
        protected override string Visit(Employee emp)
        {
            return $"First Name : {emp.FirstName} Second Name: {emp.SecondName} Salary: {emp.Salary}";
        }
    }
}
