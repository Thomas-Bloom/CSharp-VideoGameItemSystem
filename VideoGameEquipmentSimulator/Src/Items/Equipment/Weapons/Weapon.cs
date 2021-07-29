using System;
using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem.Src.Equipment.Weapons
{
    abstract class Weapon : Item
    {
        protected int AttackPower { get; }
        protected int AttackSpeed { get; }

        public Weapon(string itemName, int value, float weight, int attackPower, int attackSpeed) : base(itemName, value, weight)
        {
            AttackPower = attackPower;
            AttackSpeed = attackSpeed;
        }

        public override void PrintStats()
        {
            Console.WriteLine("Weapon - Name: " + ItemName + ", Value: " + Value + ", Attack Power: " + AttackPower + ", Attack Speed: " + AttackSpeed);
        }
    }
}
