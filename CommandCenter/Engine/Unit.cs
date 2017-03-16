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

        protected uint MaximumHealth { get; set; }
        public bool IsDead
        {
            get { return CurrentHealth <= 0; }
            set {}
        }

        private uint _level;
        public uint UnitLevel
        {
            get { return _level; }
            protected set { _level = value; }
        }


        public Unit(uint currentHealth, uint maximumHealth)
        {
            _currentHealth = currentHealth;
            MaximumHealth = maximumHealth;
            IsDead = false;
            _level = 1;
        }

        // Place attack functions here?
    }
}
