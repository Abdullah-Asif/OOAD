using System;

namespace Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderBuilder = new PizzaOrderBuilder();
            orderBuilder.ChooseMeat("Beef");
            orderBuilder.SetCheese();
            orderBuilder.SetSpiceLevel(3);
            var order = orderBuilder.Getorder(); 
        }
    }
}
