using System;
namespace AbstractFactory
{
    public abstract class WeaponFactory
    {
        public abstract Bomb CreateBomb();
        public abstract Missile CreateMissile();
        public abstract MachineGun  CreateMachineGun();
    }
}