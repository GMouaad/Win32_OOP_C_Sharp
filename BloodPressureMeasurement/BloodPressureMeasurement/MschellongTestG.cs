using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureMeasurement
{
    class MschellongTestG : MGenericTestG
    {
        public MschellongTestG(string name) : base(name)
        {
            MMeasurementArrayG = new MMeasurementG[6];
        }
        //MMeasurementG MMeasurementArrayG = new MMeasurementG[6];
        public string MAnalizeValuesG()
        {
            string MAnalysG = "dumb text in schellongTest";
            return MAnalysG;
        }
    }

}
