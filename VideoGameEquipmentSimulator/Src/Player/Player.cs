using System;
using VideoGameItemSystem.Src.Items;

namespace VideoGameEquipmentSimulator.Src.Player
{
    class Player
    {
        private Inventory inventory;
        private string playerName;
        private int inventorySize;

        public Player(string playerName, int inventorySize)
        {
            this.playerName = playerName;
            this.inventorySize = inventorySize;
            inventory = new Inventory(inventorySize);
        }

        public Inventory GetInventory()
        {
            return inventory;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {playerName} | Inventory Size: {inventorySize}");
        }
    }
}
