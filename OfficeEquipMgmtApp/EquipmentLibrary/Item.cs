using System;

namespace EquipmentLibrary
{
    internal class Item : Equipment
    {
        Decimal price; //use decimal type for anything related to money/currency      
        string name;
        string serial_model_number;

        internal Item(Decimal price, string name, string id)
        {
            this.price = price;
            this.name = name;
            serial_model_number = id;
        }    
       
    }
}
