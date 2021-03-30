using System;

namespace AbstractFactory
{
    public class F16MachineGun : MachineGun
    {
        public override  void Fire()
        {
            Console.WriteLine("Firing F16 MachineGun");
        }
    }
}
