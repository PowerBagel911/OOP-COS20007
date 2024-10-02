using System;
using _2._4___OOP;
using SwinAdventure;

namespace YourApplicationNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local variable declarations within the static Main method
            Player player = new Player("Hero", "A brave adventurer");
            LookCommand lookCommand = new LookCommand();
            Item sword = new Item(new string[] { "sword", "blade" }, "a bronze sword", "This is a sharp bronze sword.");
            Bag bag = new Bag(new string[] { "bag" }, "leather bag", "A small leather bag.");

            // Add items to player's inventory
            player.Inventory.Put(sword);
            player.Inventory.Put(bag);

            // Add an item to the bag
            Item gem = new Item(new string[] { "gem" }, "a shiny gem", "A sparkling red gem.");
            bag.Inventory.Put(gem);

            // Testing the look command
            string result = lookCommand.Execute(player, new string[] { "look", "at", "me" });
            Console.WriteLine(result);
            Console.WriteLine("Hi");

            result = lookCommand.Execute(player, new string[] { "look", "at", "gem", "in", "bag" });
            Console.WriteLine(result);

            result = lookCommand.Execute(player, new string[] { "look", "at", "unknown" });
            Console.WriteLine(result);
        }
    }
}
