using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EquipmentLibrary
{
    public class EquipmentContext : DbContext
    {
        public DbSet<Equipment> Equip { get; set; }
        public DbSet<Manufacturer> Manuf { get; set; }
    }
}
