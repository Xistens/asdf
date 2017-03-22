using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace src.Items
{
    public class InventoryItem : INotifyPropertyChanged
    {
        private Item _Details;
        private uint _Quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public Item Details
        {
            get { return _Details; }
            set
            {
                _Details = value;
                OnPropertyChanged("Details");
            }
        }

        public uint Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                OnPropertyChanged("Quantity");
                OnPropertyChanged("Description");
            }
        }

        // Return Description
        public string Description
        {
            get { return Quantity > 1 ? Details.NamePlural : Details.Name; }
        }

        // Constructor
        public InventoryItem(Item details, uint quantity = 1)
        {
            _Details = details;
            _Quantity = quantity;
        }

        // Propertychanged event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
