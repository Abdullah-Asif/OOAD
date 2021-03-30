using System;
namespace Creational
{
    public class Motor
    {
        //  sigleton pattern - basically create one class and one object of it
        private static Motor _motor;
        private Motor() { }
        public static Motor GetMotor()
        {
            if (_motor == null)
            {
                _motor = new Motor();
            }
            return _motor;
        }
    }
}