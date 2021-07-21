namespace VideoGameItemSystem.Src.Items
{
    abstract class Item
    {
        protected string itemName;
        protected int value;
        protected float weight;

        public Item(string itemName, int value, float weight)
        {
            this.itemName = itemName;
            this.value = value;
            this.weight = weight;
        }

        public abstract void PrintStats();

        public string GetItemName()
        {
            return itemName;
        }

        public int GetValue()
        {
            return value;
        }

        public float GetWeight()
        {
            return weight;
        }
    }
}
