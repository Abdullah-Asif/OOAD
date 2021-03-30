using System;
namespace AbstractFactory
{
    public abstract class Fighter
    {
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public double Speed {get; set; }
        public string Country { get; set; }
        public Fighter()
        {  
           SetWeaponFactory(); 
        }
        protected WeaponFactory WeaponMaker { get; set; }
        public void DropBomb()
        {
            var bomb = WeaponMaker.CreateBomb();
            bomb.Drop();
        }
        public void FireMissile()
        {
            var missile  = WeaponMaker.CreateMissile();
            missile .Fire();
        }
        public void FireMachineGun()
        {
            var machineGun = WeaponMaker.CreateMachineGun();
            machineGun.Fire();
        }

        public abstract void SetWeaponFactory();
    }
}