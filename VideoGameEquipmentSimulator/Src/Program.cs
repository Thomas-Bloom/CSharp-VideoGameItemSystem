using System;
using VideoGameEquipmentSimulator.Src.Player;
using VideoGameItemSystem.Src.Equipment.Armour;
using VideoGameItemSystem.Src.Equipment.Weapons;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a player (that has an inventory)
            Player player = new Player("Tom", 10);

            // Create objects for the different items
            Sword sword = new Sword("Steel Sword", 10, 3.5f, 2, 6);
            Shield shield = new Shield("Iron Shield", 2, 8f, 8);

            // Inventory Demonstration
            player.GetInventory().PrintInventory();

            // Pick up a sword and add it to the inventory
            player.GetInventory().PickUpItem(sword);
            player.GetInventory().PrintInventory();

            // Pick up a shield and add it to the inventory
            player.GetInventory().PickUpItem(shield);
            player.GetInventory().PrintInventory();

            // Drop the item in the first slot (sword)
            player.GetInventory().DropItemAtIndex(0);
            player.GetInventory().PrintInventory();

            // Pick up another sword
            // Gets added to the first slot as it was free
            player.GetInventory().PickUpItem(sword);
            player.GetInventory().PrintInventory();

            // Swap the items that are in the first two slots
            player.GetInventory().SwapItemSlots(0, 1);
            player.GetInventory().PrintInventory();

            Console.ReadLine();
        }
    }
}
