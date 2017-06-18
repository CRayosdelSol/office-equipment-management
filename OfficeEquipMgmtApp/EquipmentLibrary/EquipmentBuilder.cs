using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    class EquipmentBuilder : IEquipmentBuilder
    {

        Equipment equipment;

        public Equipment Equipment
        {
            get { return equipment; }
        }

        public void assignDepartment()
        {
            throw new NotImplementedException();
        }

        public void assignUniqueIdentifier()
        {
            throw new NotImplementedException();
        }

        public void identifyCondition()
        {
            throw new NotImplementedException();
        }

        public void identifyManufacturer()
        {
            throw new NotImplementedException();
        }

        public void identifyPrice()
        {
            throw new NotImplementedException();
        }

        public void identifyQuantity()
        {
            throw new NotImplementedException();
        }

        public void nameItem()
        {
            throw new NotImplementedException();
        }
    }
}
