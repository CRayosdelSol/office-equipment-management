using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    internal class Item
    {
        Decimal price; //use decimal type for anything related to money/currency
        int quantity;
        string type, brand;
        string serial_number;
        Manufacturer manufacturer;
        
        internal Item(Decimal price, int quantity, string type, string brand, string id, Manufacturer manuf)
        {
            this.price = price;
            this.quantity = quantity;
            this.type = type;
            this.brand = brand;
            serial_number = id;
            manufacturer = manuf;
        }
    }
}
