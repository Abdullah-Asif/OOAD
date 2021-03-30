using System;
namespace AbstractFactory
{
    public class F16WeaponFactory : WeaponFactory
    {
        public override Bomb CreateBomb()
        {
            return new F16Bomb();
        }
        public override Missile CreateMissile()
        {
            return new F16Missile();
        }
        public override MachineGun CreateMachineGun()
        {
            return new F16MachineGun();
        }
    }
}