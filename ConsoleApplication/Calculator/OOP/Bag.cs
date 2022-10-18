using System.Collections.Generic;

namespace Proxor
{
    public class Bag
    {
        public readonly List<Loot> Loot;

        public Bag()
        {
            Loot = new List<Loot>();
        }
    }
}