using System;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem.Src.Equipment.Armour
{
    abstract class Armour : Item
    {
        protected int armourRating;

        public Armour(string itemName, int value, float weight, int armourRating) : base(itemName, value, weight)
        {
            this.armourRating = armourRating;
        }

        public int GetArmourRating()
        {
            return armourRating;
        }
    }
}
