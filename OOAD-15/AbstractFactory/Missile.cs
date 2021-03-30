using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Missile
    {
        public string Model { get; set; }
        public double DamageAmount { get; set; }
        public string ImageUrl { get; set; }
        public abstract void Fire();
    }
}
