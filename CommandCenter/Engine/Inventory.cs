using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

using src.Items;

namespace src
{
    public class Inventory
    {
        private Unit _unit { get; set; }
        public BindingList<InventoryItem> UnitInventory { get; set; }

        // Constructor
        public Inventory(Unit unit)
        {
            UnitInventory = new BindingList<InventoryItem>();
            _unit = unit;
        }

        // Finds all the weapons in inventory
        public List<Weapon> Weapons
        {
            get { return UnitInventory.Where(x => x.Details is Weapon).Select(x => x.Details as Weapon).ToList(); }
        }

        // Check if item exists in inventory
        // @param itemToCheck {Item}
        // @return {InventoryItem} or null
        public InventoryItem ExistsInInventory(Item itemToCheck)
        {
            InventoryItem itemExists = UnitInventory.SingleOrDefault(x => x.Details.ID == itemToCheck.ID);

            if (itemExists == null)
                return null;

            return itemExists;
        }

        // Add an Item {Object} to the UnitInventory {InventoryObject} List
        public void AddItemToInventory(Item itemToAdd, uint quantity = 1)
        {

            InventoryItem itemExists = ExistsInInventory(itemToAdd);
            if (itemExists == null)
            {
                UnitInventory.Add(new InventoryItem(itemToAdd, quantity));
            }
            else
            {
                itemExists.Quantity += quantity;
            }
        }

        // Må endres, legge til object
        public void EquipWeapon(int id)
        {
            Weapon weaponToEquip = World.weapons[id];

            if (id == 0)
            {
                _unit.CurrentWeapon = weaponToEquip;
            }
            else
            {
                InventoryItem item = ExistsInInventory(weaponToEquip);

                if (item == null)
                {
                    _unit.RaiseMessage("Cannot equip weapon.", true);
                }
                else
                {
                    _unit.CurrentWeapon = weaponToEquip;
                }
            }
        }
    }
}
