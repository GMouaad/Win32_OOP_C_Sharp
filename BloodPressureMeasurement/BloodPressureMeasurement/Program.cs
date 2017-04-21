using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodPressureMeasurement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ///////////
            MGenericTestG Test1 = new MGenericTestG("patientName", DateTime.Now);
            MGenericTestG Test2 = new MGenericTestG("Mouaad", DateTime.Now);
            MGenericTestG Test3 = new MGenericTestG("Asmae", DateTime.Now);

            Test1.setName("patientName");
            Test2.setName("Mouaad");
            Test3.setName("Asmae");

            Test1.print();
            Test2.print();
            Test3.print();

            Random rand = new Random();

            MMeasurementG Measurement1 = new MMeasurementG(rand.Next(70, 140), rand.Next(40, 120), rand.Next(40, 80), DateTime.Now);
            MMeasurementG Measurement2 = new MMeasurementG(rand.Next(70, 140), rand.Next(40, 120), rand.Next(40, 80), DateTime.Now);
            MMeasurementG Measurement3 = new MMeasurementG(rand.Next(70, 140), rand.Next(40, 120), rand.Next(40, 80), DateTime.Now);

            Measurement1.printValues();
            Measurement2.printValues();
            Measurement3.printValues();

        }
    }
}
