using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    class StickFigure
    {
        public static Graphics drawArea;

        public static void DrawAll(object o)
        {
            Panel pnl = ((Panel)o);
            drawArea = pnl.CreateGraphics();

            drawHead();
            drawTorso();
            drawLeftArm();
            drawRightArm();
            drawLeftLeg();
            drawRightLeg();

            drawArea.Dispose();
        }

        public static void drawHead()
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawEllipse(pen, 115, 350, 50, 50);
            drawArea.FillEllipse(brush, 125, 365, 10, 5);
            drawArea.FillEllipse(brush, 145, 365, 10, 5);
            drawArea.DrawArc(pen, 130, 370, 20, 20, -180, -180);

            brush.Dispose();
            pen.Dispose();
        }

        public static void drawTorso()
        {
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawLine(pen, 140, 400, 140, 480);

            pen.Dispose();
        }

        public static void drawLeftArm()
        {
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawLine(pen, 140, 410, 120, 460);

            pen.Dispose();
        }

        public static void drawRightArm()
        {
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawLine(pen, 140, 410, 160, 460);

            pen.Dispose();
        }

        public static void drawLeftLeg()
        {
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawLine(pen, 140, 480, 120, 550);

            pen.Dispose();
        }

        public static void drawRightLeg()
        {
            Pen pen = new Pen(Color.Black, 3);
            drawArea.DrawLine(pen, 140, 480, 160, 550);

            pen.Dispose();
        }
    }
}
