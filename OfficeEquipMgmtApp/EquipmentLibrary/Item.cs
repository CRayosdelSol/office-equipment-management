using System;

namespace EquipmentLibrary
{
    ///<summary>
    ///Defines all properties of an item.
    ///</summary>
    public class Item
    {
        decimal price; //use decimal type for anything related to money/currency      
        string name;
        string serial_model_number;


        /// <summary>
        /// Creates an instance of the item class.
        /// </summary>
        /// <param name="price">The price of the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="id">The serial number or model number of the item.</param>
        public Item(decimal price, string name, string id)
        {
            this.price = price;
            this.name = name;
            serial_model_number = id;
        }    
       
    }
}
