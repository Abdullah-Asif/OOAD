using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class MachineGun
    {
        public string Model { get; set; }
        public double FirePower { get; set; }
        public int RoundCapacity { get; set; }
        public abstract void Fire();
    }
}
