using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XB_Configer.Model
{
    public class XB_Item
    {
        private String ItemUnitType;
        private String ItemName;
        private String ItemDisplayType;
        private int ItemID;

        public XB_Item(String name, String unitType, String displayType, int id)
        {
            this.ItemName = name;
            this.ItemUnitType = unitType;
            this.ItemDisplayType = displayType;
            this.ItemID = id;
        }

        public String getItemName()
        {
            return ItemName;
        }

        public String getItemDisplayType()
        {
            return ItemDisplayType;
        }

        public String getItemUnitType()
        {
            return ItemUnitType;
        }

        public int getItemID()
        {
            return ItemID;
        }
    }
}
