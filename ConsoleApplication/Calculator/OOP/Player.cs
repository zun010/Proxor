using System;

namespace Proxor
{
    public sealed class Player : Entity
    {
       public int Starvation { get; set; }
       public int Hydration { get; set; }

       public State State { get; set; } = State.Idle;

       public GoForwardResult GoForward()
       {
           Random random = new Random();
           int way = random.Next(3);
           switch (way)
           {
               case 0:
                   return GoForwardResult.GetEmptyResult();
               case 1:
                   return GoForwardResult.GetResultWithLoot();
               case 2:
                   return GoForwardResult.GetResultWithZombies();
               default:
                   throw new NotImplementedException();
           }
       }

       public bool Attack(Entity target)
       {
           return false;
       }

       public bool RunAway()
       {
           return false;
       }

       public bool GetLoot(Loot loot)
       {
           return false;
       }

       public bool OpenBag()
       {
           return false;
       }

       public bool EatFood(Food food)
       {
           return false;
       }
    }
}