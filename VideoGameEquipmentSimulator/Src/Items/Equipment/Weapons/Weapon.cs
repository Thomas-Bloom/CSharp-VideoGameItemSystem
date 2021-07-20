﻿using VideoGameItemSystem.Src.Items;

namespace VideoGameItemSystem.Src.Equipment.Weapons
{
    class Weapon : Item
    {
        protected int attackPower;
        protected int attackSpeed;

        public Weapon(string itemName, int value, float weight, int attackPower, int attackSpeed) : base(itemName, value, weight)
        {
            this.attackPower = attackPower;
            this.attackSpeed = attackSpeed;
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
