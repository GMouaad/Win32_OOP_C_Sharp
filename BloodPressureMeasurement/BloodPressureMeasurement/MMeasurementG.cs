using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureMeasurement
{
    public class MMeasurementG
    {
        private int MpulseG;
        private int MsystolicG;
        private int MdiastolicG;
        private DateTime MtheTimeG;
        public MMeasurementG(int MpulseG, int MdiastolicG, int MsystolicG, DateTime MtheTimeG)
        {
            this.MpulseG = MpulseG;
            this.MsystolicG = MsystolicG;
            this.MdiastolicG = MdiastolicG;
            this.MtheTimeG = MtheTimeG;
        }
        public int MgetPulseG()
        {
            return MpulseG;
        }
        public int MgetsystolicG()
        {
            return MsystolicG;
        }
        public int MgetdiastolicG()
        {
            return MdiastolicG;
        }
        public DateTime MgetTheTimeG()
        {
            return MtheTimeG;
        }
        public void printValues()
        {
            Console.WriteLine("Pulse : " + MpulseG);
            Console.WriteLine("Systolic blood pressure : " + MsystolicG);
            Console.WriteLine("Diastolic blood pressure : " + MdiastolicG);
            Console.WriteLine("Date : " + MtheTimeG);
            Console.WriteLine("");
        }
    }
}
