using System;

namespace Factory
{
    public abstract class FighterPlane
    {
        public string model;
        public int speed;
        public string bomb;
        public abstract void Fly();
        public abstract void Land();
        public abstract void FireMissile();
        public abstract void DropBomb();
        

    }
}
