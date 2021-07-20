using System;
using VideoGameItemSystem.Src.Equipment.Armour;
using VideoGameItemSystem.Src.Equipment.Weapons;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory playerInventory = new Inventory(10);
            Sword sword = new Sword("Fancy Sword", 10, 3.5f, 2, 6);
            Shield shield = new Shield("Sick Shield", 2, 8f, 8);
            playerInventory.PrintInventory();
            playerInventory.PickUpItem(sword);
            playerInventory.PrintInventory();
            playerInventory.PickUpItem(shield);
            playerInventory.PrintInventory();
            
            Console.ReadLine();
        }
    }
}
