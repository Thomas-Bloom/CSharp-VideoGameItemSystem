using System;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem.Src.Equipment.Weapons
{
    abstract class Weapon : Item
    {
        protected int attackPower;
        protected int attackSpeed;

        public Weapon(string itemName, int value, float weight, int attackPower, int attackSpeed) : base(itemName, value, weight)
        {
            this.attackPower = attackPower;
            this.attackSpeed = attackSpeed;
        }

        public override void PrintStats()
        {
            Console.WriteLine("Weapon - Name: " + itemName + ", Value: " + value + ", Attack Power: " + attackPower + ", Attack Speed: " + attackSpeed);
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetAttackSpeed()
        {
            return attackSpeed;
        }
    }
}
