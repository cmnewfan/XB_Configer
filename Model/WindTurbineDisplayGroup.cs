using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XB_Configer.Model
{
    public class WindTurbineDisplayGroup
    {
        private int groupID;
        private String groupName;
        public IEnumerable<XB_Item> groupItems
        {
            get;
            set;
        }
        public Object Tag
        {
            get;
            set;
        }

        public WindTurbineDisplayGroup(int id, String name, IEnumerable<XB_Item> items)
        {
            this.groupID = id;
            this.groupName = name;
            this.groupItems = items;
        }

        public int getGroupID()
        {
            return groupID;
        }

        public String getGroupName()
        {
            return groupName;
        }
    }
}
