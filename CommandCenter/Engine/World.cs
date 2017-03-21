using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using src.Items;

namespace src
{
    public static class World
    {
        public static readonly List<Weapon> weapons = new List<Weapon>();

        static World()
        {
            PopulateWeapons();
        }

        private static void PopulateWeapons()
        {
            weapons.Add(new Weapon(1, "Broken Dagger", "Daggers", 0.2f, 1, 5));
            weapons.Add(new Weapon(2, "Rock Mace", "Maces", 0.2f, 3, 8));
            weapons.Add(new Weapon(3, "Well-Used Sword", "Swords", 0.5f, 100, 120));
        }

        public static Item ItemByID(int id)
        {
            return weapons.SingleOrDefault(x => x.ID == id);
        }
    }
}
