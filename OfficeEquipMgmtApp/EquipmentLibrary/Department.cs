using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EquipmentLibrary
{
    public class Department
    {
        string departMentID;
        List<Equipment> deptEquipment;
        static Department departmentInstance;


        public List<Equipment> DeptEquipment
        {
            get { return deptEquipment; }
            set { deptEquipment = value; }
        }

        public string DepartmentID
        {
            get { return departMentID; }
            set { departMentID = value; }
        }

        public static Department introduceDepartment(List<Equipment>equipments, string ID)
        {
            if(departmentInstance == null)
            {
                departmentInstance = new Department(ID);
            }

            return departmentInstance;
        }

        public Department(string ID)
        {
            departMentID = ID;
        }

        public Department() { }
    }
}
