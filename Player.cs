using System;
namespace _2._4___OOP
{
	public class Player : GameObject, IHaveInventory
	{
        private Inventory _inventory;
		public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
			_inventory = new Inventory();
		}

        

        // Locate checks if the item is in the inventory or it’s the player itself
        public override GameObject? Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public override string FullDescription
        {
            get
            {
                string description = $"You are {Name}, {base.FullDescription}.\nYou are carrying:\n{_inventory.ItemList}";
                return description;
            }
        }
    }


}

