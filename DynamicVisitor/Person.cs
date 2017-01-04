using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
