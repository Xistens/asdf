using System;
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
            PlayerInventory = new Inventory(this);
            PlayerInventory.AddItemToInventory(World.weapons[1], this);
            EquipWeapon(0);
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(100, 100);

            /*
             * Armor, Mount etc kan være underclasser men må ikke
             * 
             * this.Inventory.getItem(id or name)
             * */
            return player;
        }
        
        public void EquipWeapon(int id)
        {
            if (id == 0)
            {
                // Unequip weapon
                CurrentWeapon = null;
            }
            else
            {
                // Find Weapons in inventory that matches the given id
                Weapon weaponToEquip = PlayerInventory.Weapons.SingleOrDefault(x => x.ID == id);

                if (weaponToEquip == null)
                {
                    RaiseMessage("There is no weapon to equip.");
                }
                else
                {
                    if (weaponToEquip.CheckLevelRequirement())
                    {
                        CurrentWeapon = weaponToEquip;
                    }
                    else
                    {
                        RaiseMessage("Level too low to use weapon!");
                    }
                }
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
