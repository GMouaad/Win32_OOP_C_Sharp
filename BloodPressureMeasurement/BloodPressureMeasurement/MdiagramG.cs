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
            g.DrawLine(Pens.Gray, 80, 170, 620, 170);
            g.DrawLine(Pens.Gray, 80, 190, 620, 190);
            g.DrawLine(Pens.Gray, 80, 210, 620, 210);
            g.DrawLine(Pens.Gray, 80, 230, 620, 230);
            g.DrawLine(Pens.Gray, 80, 250, 620, 250);
            g.DrawLine(Pens.Gray, 80, 270, 620, 270);
            g.DrawLine(Pens.Gray, 80, 290, 620, 290);
            g.DrawLine(Pens.Gray, 80, 310, 620, 310);
            g.DrawLine(Pens.Gray, 80, 330, 620, 330);
            g.DrawLine(Pens.Gray, 80, 350, 620, 350);
            g.DrawLine(Pens.Gray, 80, 370, 620, 370);
            g.DrawLine(Pens.Black, 80, 30, 80, 390);
            g.DrawLine(Pens.Black, 80, 390, 640, 390);


        }
    }
}
