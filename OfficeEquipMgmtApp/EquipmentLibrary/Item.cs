﻿using System;

namespace EquipmentLibrary
{
    ///<summary>
    ///Defines all properties of an item.
    ///</summary>
    public class Item
    {
        decimal price; //use decimal type for anything related to money/currency      
        string name;
        string condition;
        int itemID;

        public string Condition
        {
            get { return Condition1; }
            set { Condition1 = value; }
        }

        public int ItemID { get => itemID; set => itemID = value; }
        public string Condition1 { get => condition; set => condition = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        /// <summary>
        /// Creates an instance of the item class.
        /// </summary>
        /// <param name="price">The price of the item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="id">The serial number or model number of the item.</param>
        /// <param name="condition">The current state of the equipment.</param>
        public Item(decimal price, string name, int id, string condition)
        {
            this.Price = price;
            this.Name = name;
            this.Condition1 = condition;
            ItemID = id;
        }

        public Item() { }
    }
}
