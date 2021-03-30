using System;
namespace AbstractFactory
{
    public class Mirage5WeaponFactory : WeaponFactory
    {
        public override Bomb CreateBomb()
        {
            return new Mirage5Bomb();
        }
        public override Missile CreateMissile()
        {
            return new Mirage5Missile();
        }
        public override MachineGun CreateMachineGun()
        {
            return new Mirage5MachineGun();
        }
    }
}