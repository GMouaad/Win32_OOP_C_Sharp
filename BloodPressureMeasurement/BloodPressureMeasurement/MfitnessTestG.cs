using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureMeasurement
{
    class MfitnessTestG :  MGenericTestG
    {
        public MfitnessTestG(string name) : base(name)
            {
            MMeasurementArrayG = new MMeasurementG[4];
        }
        //MMeasurementG MMeasurementArrayG = new MMeasurementG[4];
        public string MAnalizeValuesG()
        {
            string MAnalysG = "dumb text in fitnessTest";
            return MAnalysG;
        }
    }
}
