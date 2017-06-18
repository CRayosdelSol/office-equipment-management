using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    public class ConditionList : IEnumerable
    {
        public List<Condition> conditionList = new List<Condition>();

        public List<Condition> GetList
        {
            get
            {
                return conditionList;
            }

            set
            {
                conditionList = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return conditionList.GetEnumerator();
        }
    }

    public class Condition
    {
        public string value;
        public int priority;

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public Condition()
        { }

    }
}
