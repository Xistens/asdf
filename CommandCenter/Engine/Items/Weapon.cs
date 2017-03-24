namespace src.Items
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public string GetBaseDamage
        {
            get { return MinimumDamage + " - " + MaximumDamage; }
            private set { }
        }

        public Weapon(Unit unit, int id, string name, string namePlural, float price,
            int minDmg, int maxDmg, uint levelRequirement, int maxStackableQuantity) : base(unit, id, name, namePlural,
                price, levelRequirement, maxStackableQuantity)
        {
            MinimumDamage = minDmg;
            MaximumDamage = maxDmg;
        }
    }
}
