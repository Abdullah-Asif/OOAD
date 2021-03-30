using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Mig29MachineGun : MachineGun
    {
        public override  void Fire()
        {
            Console.WriteLine("Firing Mig29 MachineGun");
        }
    }
}
