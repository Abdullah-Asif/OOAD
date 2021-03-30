using System;
namespace AbstractFactory
{
    public  class F16 : Fighter
    {
        public override void SetWeaponFactory()
        {
            WeaponMaker = new F16WeaponFactory();
        }
    }
}