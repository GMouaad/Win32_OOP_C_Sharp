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
        //creat a Constractor
        public MGenericTestG(string name, DateTime theTime)
        {
            this.name = "No Name given!";
            theTime = DateTime.Now;
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
        }

    }
}
