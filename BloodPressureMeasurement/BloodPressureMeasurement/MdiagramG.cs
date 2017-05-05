using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BloodPressureMeasurement
{
    public class MdiagramG : Panel
    {
        public MdiagramG()
        {
            this.Paint += new PaintEventHandler(MpaintG);
        }
        private void MpaintG(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawLine(Pens.Gray, 80, 30, 620, 30);
            g.DrawLine(Pens.Gray, 80, 50, 620, 50);
            g.DrawLine(Pens.Gray, 80, 70, 620, 70);
            g.DrawLine(Pens.Gray, 80, 90, 620, 90);
            g.DrawLine(Pens.Gray, 80, 110, 620, 110);
            g.DrawLine(Pens.Gray, 80, 130, 620, 130);
            g.DrawLine(Pens.Gray, 80, 150, 620, 150);
            g.DrawLine(Pens.Black, 80, 10, 640, 30);

        }
    }
}
