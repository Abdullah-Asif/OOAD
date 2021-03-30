using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FighterPlaneFactory();
            var plane = factory.GetFighterPlane(1);
            plane.Fly();
            plane.FireMissile();
            plane.Land();
            
        }
    }
}
