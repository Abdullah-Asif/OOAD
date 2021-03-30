using System;

namespace AbstractFactory
{
    public class F16Missile : Missile
    {
        public override void Fire()
        {
            Console.WriteLine("Fire F16 Missile");
        }
    }
}
