using System;
namespace AbstractFactory
{
    public  class Mirage5 : Fighter
    {
        public override void SetWeaponFactory()
        {
            WeaponMaker = new Mirage5WeaponFactory();
        }
    }
}