﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using src.Items;

namespace src
{
    public class Player : Unit
    {
        public Inventory PlayerInventory;
        public uint experiencePoints { get; private set; }

        private Player(uint currentHealth, uint maximumHealth) : base(currentHealth, maximumHealth)
        {
            PlayerInventory = new Inventory();
            PlayerInventory.AddItemToInventory(World.weapons[0]);
            EquipWeapon(0);
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(100, 100);
            //player.PlayerInventory.Add(new Inventory(World.ItemByID(1), 1));

            /*
             * player.Inventory = new Inventory(player)
             * player.Health = new Health(player);
             * player.Mount = new Mount(player);
             * player.Armor = new Armor(player);
             * 
             * Armor, Mount etc kan være underclasser men må ikke
             * 
             * this.Inventory.getItem(id or name)
             * */
            return player;
        }

        // Må endres, legge til object
        public void EquipWeapon(int id)
        {
            Weapon weaponToEquip = World.weapons[id];
            InventoryItem item = PlayerInventory.ExistsInInventory(weaponToEquip);

            if (item == null)
            {
                RaiseMessage("Cannot equip weapon.", true);
            }
            else
            {
                CurrentWeapon = weaponToEquip;
            }
        }

        // Adds experience points to the player. Test function
        public void SetExperience(uint experience)
        {
            uint XPRequired = Experience.XPRequired(UnitLevel);
            uint total = experiencePoints + experience;

            // Level up?
            if (total >= XPRequired)
            {
                experiencePoints = total - XPRequired;
                UnitLevel += 1;
            }
            else
            {
                experiencePoints += experience;
            }
        }

        private void RaiseInventoryChangedEvent(Item item)
        {
            if (item is Weapon)
                OnPropertyChanged("Weapons");
        }

    }
}
