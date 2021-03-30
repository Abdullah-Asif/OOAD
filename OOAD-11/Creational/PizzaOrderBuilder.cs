using System;
namespace Creational
{
    public class PizzaOrderBuilder
    {
        // builder pattern
       private PizzaOrder _order;
       public PizzaOrderBuilder()
       {
           _order = new PizzaOrder();
       }
       public void SetCheese()
       {
           _order.UseCheese = true;
       }
       public void SetSausage()
       {
           _order.UseSausage = true;
       }
       public void  ChooseMeat(string meat)
       {
           _order.Meat = meat;
       }
       public void SetSpiceLevel(int level)
       {
           _order.SpiceLevel = level;
       }
       public void ProvideHomeDelivery()
       {
           _order.HomeDelivery = true;
       }
       public PizzaOrder Getorder()
       {
           return _order;
       }
        
    }
}