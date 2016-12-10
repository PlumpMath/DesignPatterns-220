using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    interface IFactory
    {
        IProductA GetProductA();
        IProductB GetProductB();
        IProductC GetProductC();
    }
}
