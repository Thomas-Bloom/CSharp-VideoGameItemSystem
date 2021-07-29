namespace VideoGameItemSystem.Src.Items
{
    abstract class Item
    {
        public string ItemName { get; }
        public int Value { get; }
        public float Weight { get; }

        public Item(string itemName, int value, float weight)
        {
            ItemName = itemName;
            Value = value;
            Weight = weight;
        }

        public abstract void PrintStats();
    }
}
