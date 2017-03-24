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

        // Use GUID instead
        private static void PopulateWeapons()
        {
            weapons.Add(new Weapon(null, 0, "", "", 0f, 0, 0, 0, 0));
            weapons.Add(new Weapon(null, 1, "Broken Dagger", "Daggers", 0.2f, 1, 5, 1, 99));
            weapons.Add(new Weapon(null, 2, "Rock Mace", "Maces", 0.2f, 3, 8, 1, 99));
            weapons.Add(new Weapon(null, 3, "Well-Used Sword", "Swords", 0.5f, 100, 120, 5, 2));
        }

        public static Item ItemByID(int id)
        {
            return weapons.SingleOrDefault(x => x.ID == id);
        }
    }
}
