using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Unit
    {
        private uint _currentHealth;

        public uint CurrentHealth
        {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public uint MaximumHealth { get; set; }
        public bool IsDead { get; set; }

        public Unit(uint currentHealth, uint maximumHealth)
        {
            _currentHealth = currentHealth;
            MaximumHealth = maximumHealth;
        }

        // Place attack functions here?
    }
}
