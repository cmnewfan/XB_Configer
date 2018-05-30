using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XB_Configer.Model
{
    public class WindTurbine
    {
        private int windID;
        private String windName;
        public List<WindTurbineDisplayGroup> displayGroups = new List<WindTurbineDisplayGroup>();
        public WindTurbineDisplayGroup controlGroup
        {
            get;
            set;
        }
        
        public Object Tag
        {
            get;
            set;
        }

        public WindTurbine(int id, String name)
        {
            this.windID = id;
            this.windName = name;
        }

        public int getWindTurbineID()
        {
            return windID;
        }

        public String getWindTurbineName()
        {
            return windName;
        }
    }
}
