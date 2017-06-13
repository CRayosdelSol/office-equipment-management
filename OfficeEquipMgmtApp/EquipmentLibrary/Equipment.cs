namespace EquipmentLibrary
{
    ///<summary>
    ///Defines all properties of any office equipment.
    ///</summary>
    public class Equipment : Item
    {
        Manufacturer manufacturer;
        int quantity;
        double departmentID;

        /// <summary>
        /// Creates an instance of the equipment class
        /// </summary>
        /// <param name="manufacturer">Defines who the manufacturer of the equipment is.</param>
        /// <param name="quantity">How many of this item is currently available.</param>
        /// <param name="departmentID">In which department does this piece of equipment belong in.</param>
        /// <param name="price">How much money was spent to buy this piece of equipment.</param>
        /// <param name="equipmentName">The name of this equipment.</param>
        /// <param name="equipmentID">The serial number or model number of this item.</param>
        public Equipment(Manufacturer manufacturer, int quantity, double departmentID, decimal price, string equipmentName, string equipmentID) : base(price, equipmentName, equipmentID)
        {
            this.manufacturer = manufacturer;
            this.quantity = quantity;
            this.departmentID = departmentID;
        }
    }
}
