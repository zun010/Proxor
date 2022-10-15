namespace Proxor
{
    public sealed class Player : Entity
    {
       public int Starvation { get; set; }
       public int Hydration { get; set; }

       public bool GoForward()
       {
           return false;
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