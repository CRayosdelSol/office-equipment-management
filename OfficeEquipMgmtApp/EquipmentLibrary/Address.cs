using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    internal class Address
    {
        string country, city;
        int zipcode;

        /// <summary>
        /// Agregates address information into individually accessible fields
        /// </summary>
        /// <param name="ctry">Country code (3 letters at most)</param>
        /// <param name="city">City address</param>
        /// <param name="zip">Zipcode</param>
        internal Address(string ctry, string city, int zip)
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
    }
}
