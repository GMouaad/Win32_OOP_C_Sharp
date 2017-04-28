using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureMeasurement
{
    class MGenericTestG
    {
        private string name;
        private DateTime date;
        protected MMeasurementG[] MMeasurementArrayG;
        //creat a Constractor
        public MGenericTestG(string name, DateTime theTime)
        {
            this.name = "No Name given!";
            theTime = DateTime.Now;
        }
        public void MreadValuesG()
        {
            Random rand = new Random();
            int pulse, systolic, diastolic;
            for (int i = 0; i < MMeasurementArrayG.Length; i++)
            {
                pulse = rand.Next(70, 140);
                systolic = rand.Next(40, 120);
                diastolic = rand.Next(40, 80);
                MMeasurementArrayG[i] = new MMeasurementG(pulse, diastolic, systolic, DateTime.now);
            }
        }
        class MfitnessTestG : MGenericTestG
        {
            public MfitnessTestG(string name) : base(name)
            {
                MMeasurementG[] Array = MGenericTestG.MMeasurementArrayG;
            }
            MMeasurementG MMeasurementArrayG = new MMeasurementG[4];
            public string MAnalizeValuesG()
            {
                string MAnalysG = "dumb text in fitnessTest";
                return MAnalysG;
            }
        }
        class MschellongTestG : MGenericTestG
        {
            public MschellongTestG(string name) : base(name)
            {
                MMeasurementG[] MMeasurementArrayG = null;
            }
            MMeasurementG MMeasurementArrayG = new MMeasurementG[6];
            public string MAnalizeValuesG()
            {
                string MAnalysG = "dumb text in schellongTest";
                return MAnalysG;
            }
        }
        //set value of name 
        //string name { get; set; }
        public void setName(string newName)
        {
            name = newName;
        }
        //get value of name
        public string MgetNameG()
        {
            return (name);
        }

        public DateTime MgetTimeG()
        {
            return date;
        }
        public void print()
        {
            Console.WriteLine("Name :{0}\n", name);
            Console.WriteLine("Pulse : " + MpulseG);
            Console.WriteLine("Systolic blood pressure : " + MsystolicG);
            Console.WriteLine("Diastolic blood pressure : " + MdiastolicG);
            Console.WriteLine("Date : " + MtheTimeG);
            Console.WriteLine("");
        }
        public MGenericTestG[] MgetArrayG()
        {
            return MMeasurementArrayG;
        }


    }
}
