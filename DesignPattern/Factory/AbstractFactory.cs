using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }

    public interface IProduct
    {
        void Show();
    }

    public class ProductA : IProduct
    {
        public override void Show()
        {
            Console.WriteLine("Product A");
        }
    }

    public class ProductB : IProduct
    {
        public override void Show()
        {
            Console.WriteLine("Product B");
        }
    }
    public class FactoryA : IFactory
    {

        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class Client
    {
        public void OrderProduct()
        {
            IFactory factory = new FactoryA();
            factory.CreateProduct();
        }
    }
}
