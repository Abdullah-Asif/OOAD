using System;

namespace Factory
{
    public class F16PLane : FighterPlane
    {
        public override void Fly()
        {
            Console.WriteLine("Flying F16");
        }
        public override void Land()
        {
            Console.WriteLine("Landing F16");
        }
        public override void FireMissile()
        {

        }
        public override void DropBomb()
        {

        }
        

    }
}
