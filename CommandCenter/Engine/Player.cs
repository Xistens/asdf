using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Player : Unit
    {
        public string _Name { get; set; }

        private Player(string name, uint currentHealth, uint maximumHealth) : base(currentHealth, maximumHealth)
        {
            _Name = name;
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player("TEST", 1, 1);
            return player;
        }

    }
}
