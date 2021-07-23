using System;

namespace VideoGameItemSystem.Src.Items
{
    class Inventory
    {
        // Inventory only holds Items
        protected Item[] items;

        // Set the size of the array (size of inventory) based on numSlots
        public Inventory(int numSlots)
        {
            items = new Item[numSlots];
        }

        public void PickUpItem(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                // Checks for the first available slot (doesn't contain an Item)
                if (!HasSlotGotAnItem(i))
                {
                    Console.WriteLine("Picked up: " + item.GetItemName());
                    // Add the item to the array at the first available slot
                    items[i] = item;
                    break;
                }
            }
        }

        public void DropItemAtIndex(int slotIndex)
        {
            // Check that the slot contains an item
            if (HasSlotGotAnItem(slotIndex))
            {
                // If it does, set the slot to null (removes the item from inventory)
                Console.WriteLine("Dropped: " + GetItemAtSlot(slotIndex)?.GetItemName());
                items[slotIndex] = null;
            }
            else
            {
                Console.WriteLine("No item in that slot");
            }
        }

        // Swap the items in each slot
        public void SwapItemSlots(int firstSlot, int secondSlot)
        {
            if(IsSlotInRange(firstSlot) && IsSlotInRange(secondSlot))
            {
                // Check to make sure both slots contain items
                if (GetItemAtSlot(firstSlot) != null && GetItemAtSlot(secondSlot) != null)
                {
                    Item tempItem = GetItemAtSlot(firstSlot);
                    items[firstSlot] = GetItemAtSlot(secondSlot);
                    items[secondSlot] = tempItem;
                    Console.WriteLine("Swapped slots (" + firstSlot + ") and (" + secondSlot + ")");
                }
                else
                {
                    Console.WriteLine("One or both slots are empty");
                }
            }
            else
            {
                Console.WriteLine("Inventory too small to swap");
            }
        }

        // Perform a check to see if the slot already contains an item
        protected bool HasSlotGotAnItem(int index)
        {
            if (IsSlotInRange(index))
            {
                return (items[index] != null);
            }
            else
            {
                return false;
            }
        }

        // Return the item that is in a given slot
        public Item GetItemAtSlot(int slotIndex)
        {
            if (IsSlotInRange(slotIndex))
            {
                if (slotIndex < items.Length)
                    return HasSlotGotAnItem(slotIndex) ? items[slotIndex] : null;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        private bool IsSlotInRange(int slotIndex)
        {
            return (slotIndex < items.Length) ? true : false;
        }

        public void PrintInventory()
        {
            Console.Write("Inventory: ");
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                    Console.Write(items[i].GetItemName());
                else
                    Console.Write("None");

                if (i < items.Length - 1)
                    Console.Write(" | ");
            }

            Console.WriteLine();
        }
    }
}
