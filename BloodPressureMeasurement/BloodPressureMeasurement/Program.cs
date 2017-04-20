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
            MGenericTestG Test1 = new MGenericTestG();
            MGenericTestG Test2 = new MGenericTestG();
            MGenericTestG Test3 = new MGenericTestG();

            Test1.name = "Testing function 1";
            Test2.name = "Testing function 2";
            Test3.name = "Testing function 3";

            MGenericTestG.print(Test1);
            MGenericTestG.print(Test2);
            MGenericTestG.print(Test3);
        }
    }
}
