using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Mirage5MachineGun : MachineGun
    {
        public override  void Fire()
        {
            Console.WriteLine("Firing Mirage5 MachineGun");
        }
    }
}
