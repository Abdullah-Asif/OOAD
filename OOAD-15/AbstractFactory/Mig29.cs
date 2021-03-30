using System;
namespace AbstractFactory
{
    public  class Mig29 : Fighter
    {
        public override void SetWeaponFactory()
        {
            WeaponMaker = new Mig29WeaponFactory();
        }
    }
}