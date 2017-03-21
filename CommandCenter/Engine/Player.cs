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

        public uint experiencePoints { get; private set; }
        public BindingList<Inventory> PlayerInventory { get; set; }

        private Player(uint currentHealth, uint maximumHealth) : base(currentHealth, maximumHealth)
        {
            SetCurrentWeapon(1);
            PlayerInventory = new BindingList<Inventory>();
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(100, 100);
            player.PlayerInventory.Add(new Inventory(World.ItemByID(1), 1));
            return player;
        }

        public void SetCurrentWeapon(int id)
        {
            CurrentWeapon = (Weapon)World.ItemByID(id);
        }

        public void AddItemToInventory(Item itemToAdd, int quantity = 1)
        {
            Inventory existingItemInInventory = PlayerInventory.SingleOrDefault(x => x.Details.ID == itemToAdd.ID);

            if (existingItemInInventory == null)
            {
                PlayerInventory.Add(new Inventory(itemToAdd, quantity));
            }
            else
            {
                existingItemInInventory.Quantity += quantity;
            }

            RaiseInventoryChangedEvent(itemToAdd);

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
