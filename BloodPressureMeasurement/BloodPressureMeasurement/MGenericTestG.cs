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
        public MGenericTestG(string name)
        {
            this.name = "No Name given!";
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
                MMeasurementArrayG[i] = new MMeasurementG(pulse, diastolic, systolic, DateTime.Now);
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
            for(int i= 0; i < MMeasurementArrayG.Length; i++)
            {
                MMeasurementArrayG[i].printValues();
            }
        }
        public MMeasurementG[] MgetArrayG()
        {
            return MMeasurementArrayG;
        }


    }
}
