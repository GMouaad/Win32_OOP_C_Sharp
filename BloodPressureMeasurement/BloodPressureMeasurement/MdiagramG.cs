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
        private MmainWindowG MmyMainWindowG;
        MGenericTestG McurrentTestG;
        
        public MdiagramG(MmainWindowG MmainWindowG)
        {
            this.MmyMainWindowG = MmainWindowG;
            this.Paint += new PaintEventHandler(MpaintG);

        }
        
        
        private void MpaintG(object sender, PaintEventArgs e)
        {
            McurrentTestG = MmyMainWindowG.MgetCurrentTestG();


            Graphics g = e.Graphics;
            //g.DrawLine(Pens.Gray, 80, 30, 620, 30);
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
            
            g.DrawLine(Pens.Black, 80, 40, 80, 370);

            
            g.DrawLine(Pens.Black, 80, 370, 640, 370);

            //Drawing the Axis Labels
            Font font = new Font("Helvetica", 10, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            //create Rectangle for drawing x-Axis
            RectangleF rect = new  RectangleF( 60, 20, 150, 16);
            g.DrawRectangle(Pens.Black, 60, 20, 150, 16);
            g.DrawString("Pulse/Blood pressure", font, brush, rect);

            //create Rectangle for drawing y-Axis

            RectangleF rect2 = new RectangleF(310, 380, 90, 16);
            g.DrawRectangle(Pens.Black, 310, 380, 90, 16);
            g.DrawString("Measurement", font, brush, rect2);

            MMeasurementG[] MmeasurementArrayG = McurrentTestG.MgetArrayG();

            //y1 - y2 = (hier) 40 - 370 = 330px Diagramm Höhe
            // wenn Diagramm Höhe von 330 hat, dann 330/150 = 2px für jeden Wert
            int MyAxis = 330;
            int MxAxisDistanceG = 560 / (MmeasurementArrayG.Length + 1);

            int MyAxisValueG = MyAxis / 150;
            int MxAxisValueG = MxAxisDistanceG;
            //Testing if there is a current Test
            if (McurrentTestG != null)
            {
                
                // testing if the Array is not empty
                if (MmeasurementArrayG != null)
                {
                    for (int i=0 ; i < MmeasurementArrayG.Length; i++ )
                    {
                        if (MmeasurementArrayG[i] != null)
                        {
                            //blood pressure
                            g.FillEllipse(Brushes.Green, MxAxisValueG, MyAxis - 10 - (MmeasurementArrayG[i].MgetPulseG() * MyAxisValueG), 10, 10);
                            //systolic
                            g.FillEllipse(Brushes.Red, MxAxisValueG, MyAxis - 10 - (MmeasurementArrayG[i].MgetsystolicG() * MyAxisValueG), 10, 10);
                            //diastolic
                            g.FillEllipse(Brushes.Blue, MxAxisValueG, MyAxis - 10 - (MmeasurementArrayG[i].MgetdiastolicG() * MyAxisValueG), 10, 10);


                        }
                    }
                }
                
            }
        }
    }
}
