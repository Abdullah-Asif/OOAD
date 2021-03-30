using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("\nCreated by Raizor " +  DateTime.Now + "\n");
           while(true)
           {
                var name = Console.ReadLine();
                var plane = new FighterFactory();
                var fighter1 = plane.CreateFighter(name);
                if (fighter1 == null) break;
                while (true)
                {
                    var command = int.Parse(Console.ReadLine());
                
                    if ( command == 1)
                    {
                        fighter1.DropBomb();
                    }
                    else if (command == 2)
                    {
                        fighter1.FireMissile();
                    }
                    else if (command == 3)
                    {
                        fighter1.FireMachineGun();
                    }
                    else
                    {
                        break;
                    }
                }    
           }
        }
    }
}
