using System;
namespace AbstractFactory
{
    public class Mirage5Bomb : Bomb
    {
        public override void Drop()
        {
            Console.WriteLine("Dropping Mirage5 Bomb");
        }
    }
}