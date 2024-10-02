using System;
namespace _2._4___OOP
{
	public class Inventory
	{
		public List<Item> _items;
		public Inventory()
		{
			_items = new List<Item>();
		}

		public bool HasItem(string id)
		{
			foreach (Item item in _items)
			{
				if (item.AreYou(id))
				{
					return true;
				}
			}
			return false;
		}

		public void Put(Item itm)
		{
			_items.Add(itm);
		}

        public Item? Take(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    _items.Remove(item);
					return item;
                }
            }

            return null;
        }

        public Item? Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null; // Return null if the item is not found
        }

        public string ItemList
        {
            get
            {
                string itemList = "";
                foreach (Item item in _items)
                {
                    itemList += $"\t{item.ShortDescription}\n";
                }
                return itemList;
            }
        }

    }
}

