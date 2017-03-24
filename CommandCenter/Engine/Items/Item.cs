namespace src.Items
{
    public abstract class Item
    {
        private Unit _unit { get; set; }
        public int ID { get; set; }
        public static int GUID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public float Price { get; set; }
        public uint LevelRequirement { get; set; }
        public int MaxStackableQuantity { get; set; }

        public Unit ItemUnit
        {
            get { return _unit; }
            set { _unit = value; }
        } 

        public Item (Unit unit, int id, string name, string namePlural, float price,
            uint levelRequirement, int maxStackableQuantity = 99)
        {
            GUID += 1;
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
            _unit = unit;
            LevelRequirement = levelRequirement;
            MaxStackableQuantity = maxStackableQuantity;
        }

        // Check if player meets level requirement
        public bool CheckLevelRequirement()
        {

            if (_unit.UnitLevel < LevelRequirement)
                return false;
            return true;
        }
    }
}
