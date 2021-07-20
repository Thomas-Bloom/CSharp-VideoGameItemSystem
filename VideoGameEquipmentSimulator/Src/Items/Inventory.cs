using System;

namespace VideoGameItemSystem.Src.Items
{
    class Inventory
    {
        protected Item[] items;

        public Inventory(int numSlots)
        {
            items = new Item[numSlots];
        }

        public void PickUpItem(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if (!HasSlotGotAnItem(i))
                {
                    Console.WriteLine("Picked up: " + item.GetItemName());
                    items[i] = item;
                    break;
                }
            }
        }

        public void DropItem()
        {

        }

        public void SwapItemSlots(int slot1, int slot2)
        {

        }

        protected bool HasSlotGotAnItem(int index)
        {
            return (items[index] != null);
        }

        public Item GetItemAtSlot(int slotIndex)
        {
            try
            {
                return items[slotIndex];
            }
            catch
            {
                return null;
            }
        }

        public void PrintInventory()
        {
            Console.Write("Inventory: ");
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                    Console.Write(items[i].GetItemName());
                else
                    Console.Write("None");

                if (i < items.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
