using System;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem.Src.Equipment.Armour
{
    abstract class Armour : Item
    {
        public int ArmourRating { get; }

        public Armour(string itemName, int value, float weight, int armourRating) : base(itemName, value, weight)
        {
            ArmourRating = armourRating;
        }

        public override void PrintStats()
        {
            Console.WriteLine("Weapon - Name: " + ItemName + ", Value: " + Value + ", Armour Rating: " + ArmourRating);
        }
    }
}
