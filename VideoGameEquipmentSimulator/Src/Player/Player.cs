using VideoGameItemSystem.Src.Items;

namespace VideoGameEquipmentSimulator.Src.Player
{
    class Player
    {
        private Inventory inventory;

        public Player(string playerName, int inventorySize)
        {
            inventory = new Inventory(inventorySize);
        }

        public Inventory GetInventory()
        {
            return inventory;
        }
    }
}
