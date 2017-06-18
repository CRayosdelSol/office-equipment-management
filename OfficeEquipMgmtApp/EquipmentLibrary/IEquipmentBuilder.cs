using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    public interface IEquipmentBuilder
    {
        void nameItem();
        void identifyCondition();
        void identifyPrice();
        void identifyManufacturer();
        void identifyQuantity();
        void identifyDepartment();
        Equipment Equip { get; }
    }
}
