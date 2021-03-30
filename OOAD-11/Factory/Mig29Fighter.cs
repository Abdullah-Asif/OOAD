using System;

namespace Factory
{
    public class Mig29Fighter : FighterPlane
    {
        public override void Fly()
        {
            Console.WriteLine("Flying M29");
        }
        public override void Land()
        {
            Console.WriteLine("Landing M29");   
        }
        public override void FireMissile()
        {

        }
        public override void DropBomb()
        {

        }
        

    }
}
