using System;
namespace AbstractFactory
{
    public  class FighterFactory
    {
       public Fighter CreateFighter(string type)
       {
           Fighter fighter = null;
           switch(type)
           {
               case "F16" :
                    fighter = new F16();
                    break;
               case "Mig29" :
                    fighter = new Mig29();
                    break;
               case "Mirage5" :
                    fighter = new Mirage5();
                    break;     
                default :
                    fighter = null;
                    break;
           }
           return fighter;
       }

    }
}