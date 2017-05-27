namespace EquipmentLibrary
{
    /// <summary>
    /// Aggregates address information into individually accessible fields
    /// </summary>
    public class Address
    {
        string country, city;
        int zipcode;

        /// <summary>
        /// Creates an instance of the address class
        /// </summary>
        /// <param name="ctry">Country code (3 letters at most e.g. PH,US,JP)</param>
        /// <param name="city">City address</param>
        /// <param name="zip">Zipcode</param>
        public Address(string ctry, string city, int zip)
        {
            country = ctry;
            this.city = city;
            zipcode = zip;
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public int Zipcode
        {
            get
            {
                return zipcode;
            }

            set
            {
                zipcode = value;
            }
        }

        /// <summary>
        /// Concatenates all address details into a composite string
        /// </summary>
        /// <returns>returns the address as a single string</returns>
        public override string ToString()
        {
            string str = string.Format("Address Details \nCountry: {0}\nCity: {1}\n Zip Code: {2}", country, city, zipcode);
            return str;
        }
    }
}
