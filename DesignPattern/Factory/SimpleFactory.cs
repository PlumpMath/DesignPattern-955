using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    //产品
    public class Pizza
    {
        public virtual void Prepare() { }
        public virtual void Bake() { }
        public virtual void Cut() { }
        public virtual void Box() { }
    }

    class CheesePizza : Pizza { }
    class VeggiePizza : Pizza { }
    class PepperonPizza : Pizza { }
    
    //工厂
    public class SimpleFactory
    {
        public Pizza CreatePizza(string Type)
        {
            Pizza pizza = null;
            if (Type == "Cheese")
                return new CheesePizza();
            else if (Type == "Veggie")
                return new VeggiePizza();
            else if (Type == "Pepperon")
                return new PepperonPizza();
            return pizza;
        }
    }

    //客户
    public class PizzaStore
    {
        SimpleFactory Factory;
        PizzaStore(SimpleFactory _Factory)
        {
            this.Factory = _Factory;
        }

        public Pizza orderPizza(string type)
        {
            return Factory.CreatePizza(type);
        }
    }


}
