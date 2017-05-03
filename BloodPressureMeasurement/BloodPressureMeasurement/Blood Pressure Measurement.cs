using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodPressureMeasurement
{
    public partial class Form1 : Form
    {
        MGenericTestG McurrentTestG = new MGenericTestG("Current Test");
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtnClicked(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(255, 255, 255);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtnClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void MstartG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }

        private void MreadG_Click(object sender, EventArgs e)
        {
            McurrentTestG = MgetCurrentTestG();
            McurrentTestG.MreadValuesG();
        }

        private void MendG_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnewTestMenuItemG_Click(object sender, EventArgs e)
        {
            MGenericTestG MnewTestG = new MGenericTestG("Test" + MCounterG);
            MArrayG[MCounterG] = MnewTestG;
            if (MCounterG<11)
            {
                Console.WriteLine("Test Nr. " + MCounterG);
                if (MCounterG % 2 == 0)
                {
                    MnewTestG = new MfitnessTestG("Test" + MCounterG);
                }
                else
                {
                    MnewTestG = new MschellongTestG("Test" + MCounterG);
                }
                MCounterG++;
            }
            else
            {
                Console.WriteLine("No Space anymore!");
            }
            
            
        }

        private void MeditTestItemG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }

        private void MprintTestItemG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }

        private void MloadMenuItemG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }

        private void MstoreMenuItemG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }

        private void MhelpMenuItemG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet !");
        }
    }
}
