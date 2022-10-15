namespace Proxor
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int Health { get; set; }
        
        public Weapon Weapon { get; set; }
        
        protected Bag _bag;
        
        public Entity()
        {
            _bag = new Bag();
        }
        
        public void DropAllLoot()
        {
            
        }
    }
}