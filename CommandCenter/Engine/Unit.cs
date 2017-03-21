using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

using Helpers;
using src.Events;
using src.Items;

namespace src
{
    public abstract class Unit : INotifyPropertyChanged
    {
        private uint _currentHealth;
        private uint _level;
        protected uint MaximumHealth { get; set; }
        protected int unit_min_damage { get; set; }
        protected int unit_max_damage { get; set; }
        protected int unit_crit_chance { get; set; }
        public Weapon CurrentWeapon { get; protected set; }


        public event EventHandler<MessageEventArgs> OnMessage;
        public event PropertyChangedEventHandler PropertyChanged;



        public uint CurrentHealth
        {
            get { return _currentHealth; }
            protected set { _currentHealth = value; }
        }

        public bool IsDead
        {
            get { return CurrentHealth <= 0; }
            protected set {}
        }

        // Level of the unit, player or monster
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
            unit_max_damage = 10;
            unit_min_damage = 5;
            unit_crit_chance = 5;

        }

        // Attacks

        // Is the attack a critical hit?
        private bool IsCrit()
        {
            int critChance = unit_crit_chance;
            int rand = RandomNumberGenerator.NumberBetween(0, 100);

            if (rand <= critChance)
                return true;
            return false;
        }

        // Calculating base damage
        public int CalculateDamage()
        {
            int min_damage, max_damage;

            if (CurrentWeapon == null)
            {
                min_damage = unit_min_damage;
                max_damage = unit_max_damage;
            }
            else
            {
                min_damage = unit_min_damage + CurrentWeapon.MinimumDamage;
                max_damage = unit_max_damage + CurrentWeapon.MaximumDamage;
            }

            // Just to be sure, but not really needed atm
            if (min_damage > max_damage)
            {
                // Swap
                min_damage = min_damage + max_damage;
                max_damage = min_damage - max_damage;
                min_damage = min_damage - max_damage;
            }

            // Just to be sure..
            if (max_damage == 0)
                max_damage = 10;

            // Just testing... Not intended here
            if (IsCrit())
            {
                RaiseMessage("Critical hit!", true);
                min_damage *= 2;
                max_damage *= 2;
            }

            return RandomNumberGenerator.NumberBetween(min_damage, max_damage);
        }

        private void RaiseMessage(string message, bool addExtraNewLine = false)
        {
            OnMessage?.Invoke(this, new MessageEventArgs(message, addExtraNewLine));
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
