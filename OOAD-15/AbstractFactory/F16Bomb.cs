using System;
namespace AbstractFactory
{
    public class F16Bomb : Bomb
    {
        public override void Drop()
        {
            Console.WriteLine("Dropping F16 Bomb");
        }
    }
}