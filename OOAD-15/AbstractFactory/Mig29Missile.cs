using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Mig29Missile : Missile
    {
        public override void Fire()
        {
            Console.WriteLine("Fire Mig29 Missile");
        }
    }
}
