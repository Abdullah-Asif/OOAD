using System;

namespace Factory
{
    public class FighterPlaneFactory
    {
        private FighterPlane _plane = null;

        public FighterPlane GetFighterPlane(int option)
        {
            if (option == 1)
            {
                _plane = new Mig29Fighter();
            }
            else if (option == 2)
            {
                _plane = new F16PLane();
            }
            return _plane;
        }
        
    }
}
