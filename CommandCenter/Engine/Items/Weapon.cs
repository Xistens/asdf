namespace src.Items
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public uint LevelRequirement { get; set; }

        public string GetBaseDamage
        {
            get { return MinimumDamage + " - " + MaximumDamage; }
            private set { }
        }

        public Weapon(Unit unit, int id, string name, string namePlural, float price,
            int minDmg, int maxDmg) : base(unit, id, name, namePlural, price)
        {
            MinimumDamage = minDmg;
            MaximumDamage = maxDmg;
        }
    }
}
