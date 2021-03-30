using System;
namespace AbstractFactory
{
    public class Mig29WeaponFactory : WeaponFactory
    {
        public override Bomb CreateBomb()
        {
            return new Mig29Bomb();
        }
        public override Missile CreateMissile()
        {
            return new Mig29Missile();
        }
        public override MachineGun CreateMachineGun()
        {
            return new Mig29MachineGun();
        }
    }
}