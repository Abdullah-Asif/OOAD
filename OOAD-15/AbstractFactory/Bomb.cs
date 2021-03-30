using System;
namespace AbstractFactory
{
    public abstract class Bomb
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Power { get; set; }
        public abstract void Drop();
    }
}