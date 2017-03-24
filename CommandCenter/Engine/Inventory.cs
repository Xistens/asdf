using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

using src.Items;

namespace src
{
    public class Inventory
    {
        // Should maybe not be a const, maybe the player will get a bigger bag?
        private const int MAXIMUM_SPACE_IN_INVENTORY = 5;

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

        /// <summary>
        /// Adds a new item to units inventory
        /// Unit referece is important so that we can check item level requirement etc.
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <param name="unit">Add unit reference</param>
        /// <param name="quantity">The quantity to add</param>
        public void AddItemToInventory(Item item, Unit unit, int quantity = 1)
        {
            bool breakFlag = false;
            while( (quantity > 0) && (!breakFlag))
            {
                InventoryItem existsAndMoreSpace = UnitInventory.SingleOrDefault(x => (x.Details.ID == item.ID) && (x.Quantity < item.MaxStackableQuantity));
                if(existsAndMoreSpace != null)
                {
                    // Get item from inventory and calculate how many we can add to the already existing stack
                    InventoryItem inInventory = UnitInventory.First(x => (x.Details.ID == item.ID) && (x.Quantity < item.MaxStackableQuantity));
                    int maximumToAddInStack = (item.MaxStackableQuantity - inInventory.Quantity);

                    // Add to stack. Either full quantity, or the remaning amount too reach max.
                    int addToQuantity = Math.Min(quantity, maximumToAddInStack);

                    // Add to stack and decrease the quantity added
                    inInventory.AddToQuantity(addToQuantity);
                    quantity -= addToQuantity;
                }
                else
                {
                    if (UnitInventory.Count < MAXIMUM_SPACE_IN_INVENTORY)
                    {
                        // Add new value, but let the While loop add quantity
                        item.ItemUnit = unit;
                        UnitInventory.Add(new InventoryItem(item, 0));
                    }
                    else
                    {
                        _unit.RaiseMessage("There is no space in inventory.");
                        breakFlag = true;
                    }
                }
            }
        }
    }
}
