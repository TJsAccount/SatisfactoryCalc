using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatRatCalc
{
    public class Flow : Object
    {
        public string strName { get; set; }
        public int nAmount { get; set; }

        public Flow(string _name, int _amount)
        {
            strName = _name;
            nAmount = _amount;
        }

        public Flow()
        {
            strName = "Default";
            nAmount = -1;
        }
    }

    public class SatComponent : Object
    {
        public string strName { get; set; }
        public string strBuilding { get; set; }
        public int nAmount { get; set; }
        public int nAssemblyTime { get; set; }
        public bool bRaw { get; set; }
        public List<Flow> lInputs { get; set; }

        public SatComponent(string _name, string _building, int _amount, int _assemblyTime, bool _raw, List<Flow> _inputs)
        {
            strName = _name;
            strBuilding = _building;
            nAmount = _amount;
            nAssemblyTime = _assemblyTime;
            bRaw = _raw;
            lInputs = _inputs;
        }

        public SatComponent()
        {
            //Any detection of Default or -1 values should throw up a logic error
            strName = "Default";
            strBuilding = "Default";
            nAmount = -1;
            nAssemblyTime = -1;
            bRaw = false;
            lInputs = new List<Flow>();
        }
    }
}
