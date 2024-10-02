using System;
using SwinAdventure;
using _2._4___OOP;
namespace _2._4___OOP
{
	public class Bag : Item, IHaveInventory
	{
		private Inventory _inventory;
		public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
		{
			_inventory = new Inventory();
		}

        public override GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get { return $"In the {Name} you can see:\n{_inventory.ItemList}"; }
        }

        // Property to access the Inventory (read-only)
        public Inventory Inventory
        {
            get { return _inventory; }
        }
    }

    
}

