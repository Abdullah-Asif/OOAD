using System;
namespace AbstractFactory
{
    public class Mig29Bomb : Bomb
    {
        public override void Drop()
        {
            Console.WriteLine("Dropping Mig29 Bomb");
        }
    }
}