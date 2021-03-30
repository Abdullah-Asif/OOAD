using System;

namespace Task1
{
    public class Discount : IDiscount
    {   
        public double amount;
        public double FixDiscount(double amount)
        {
            if (amount > 500)
            return amount - (amount * 10 / 100);
        }
    }
}
