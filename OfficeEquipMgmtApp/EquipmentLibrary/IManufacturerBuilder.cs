using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    public interface IManufacturerBuilder
    {
        void identifyAddress();
        void establishUserCommunicationMethods();
        Manufacturer Manufacturer { get; }
    }
}
