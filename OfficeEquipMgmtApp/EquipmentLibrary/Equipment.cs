namespace EquipmentLibrary
{
    ///<summary>
    ///Defines all properties of any office equipment.
    ///</summary>
    public class Equipment : Item
    {
        Manufacturer manufacturer;
        int quantity;
        string departmentID;
        static Equipment equipmentInstance;

        public Manufacturer Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        public static Equipment EquipmentInstance
        {
            get
            {
                return equipmentInstance;
            }

            set
            {
                equipmentInstance = value;
            }
        }



        /// <summary>
        /// Creates an instance of the equipment class
        /// </summary>
        /// <param name="manufacturer">Defines who the manufacturer of the equipment is.</param>
        /// <param name="quantity">How many of this item is currently available.</param>
        /// <param name="departmentID">In which department does this piece of equipment belong in.</param>
        /// <param name="price">How much money was spent to buy this piece of equipment.</param>
        /// <param name="equipmentName">The name of this equipment.</param>
        /// <param name="equipmentID">The serial number or model number of this item.</param>
        public Equipment(Manufacturer manufacturer, int quantity, string departmentID, decimal price, string equipmentName, int equipmentID, string equipmentCondition) : base(price, equipmentName, equipmentID, equipmentCondition)
        {
            this.manufacturer = manufacturer;
            this.quantity = quantity;
            this.departmentID = departmentID;
        }

        public Equipment() { }

        public static Equipment createEquipment(Manufacturer manufacturer, int quantity, string departmentID, decimal price, string equipmentName, int equipmentID, string equipmentCondition)
        {
            if (equipmentInstance == null)
            {
                equipmentInstance = new Equipment(manufacturer, quantity, departmentID, price, equipmentName, equipmentID, equipmentCondition);
            }

            return equipmentInstance;
        }

        public static Equipment createEquipment()
        {
            if (equipmentInstance == null)
            {
                equipmentInstance = new Equipment();
            }

            return equipmentInstance;
        }

    }
}
