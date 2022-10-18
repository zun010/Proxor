using System;
using System.Collections.Generic;

namespace Proxor
{
    public sealed class GoForwardResult
    {
        public readonly List<Zombie> Zombies;
        public readonly List<Loot> Loot;

        private string _message;

        public void ShowMessage()
        {
            Console.WriteLine(_message);
        }

        private GoForwardResult(List<Zombie> zombies, List<Loot> loot)
        {
            Zombies = zombies;
            Loot = loot;
        }

        public static GoForwardResult GetResultWithZombies()
        {
            var zombies = new List<Zombie>();
            var random = new Random();
            
            var zombieCount = random.Next(4);
            for (var i = 0; i < zombieCount; i++)
            {
                Zombie zombie = new Zombie();
                zombies.Add(zombie);
                
                zombie.AddLoot(GetRandomLoot(false));
            }
            
            var result = new GoForwardResult(zombies, null);
            
            result._message = $"Ты встретил {zombies.Count} зомби";
            
            return result;
        }
        
        public static GoForwardResult GetResultWithLoot()
        {
            var randomLoot = GetRandomLoot(true);

            var result = new GoForwardResult(null, randomLoot);

            result._message = $"Ты нашел лут!";
            
            return result;
        }

        public static GoForwardResult GetEmptyResult()
        {
            var result = new GoForwardResult(null, null);

            result._message = "Ничего не произошло";
            
            return result;
        }

        private static List<Loot> GetRandomLoot(bool includeWeapons)
        {
            var lootList = new List<Loot>();
            var random = new Random();

            var lootCount = random.Next(5);
            for (var i = 0; i < lootCount; i++)
            {
                var maxLootNumber = includeWeapons ? 5 : 3;
                var loot = GetLootByNumber(random.Next(maxLootNumber));
                lootList.Add(loot);
            }

            return lootList;
        }

        private static Loot GetLootByNumber(int number)
        {
            switch (number)
            {
                case 0:
                    return new Beer();
                case 1:
                    return new Can();
                case 2:
                    return new FirstAidKit();
                case 3:
                    return new Pistol();
                case 4:
                    return new Rifle();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}