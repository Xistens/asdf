namespace src.Items
{
    public abstract class Item
    {
        public int ID { get; set; }
        public static int GUID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public float Price { get; set; }
        private Unit _unit { get; set; }

        public Unit SetUnit
        {
            get { return _unit; }
            set { _unit = value; }
        } 

        public Item (Unit unit, int id, string name, string namePlural, float price)
        {
            GUID += 1;
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
            _unit = unit;
        }
    }
}
