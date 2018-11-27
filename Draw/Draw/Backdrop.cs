using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
    class Backdrop
    {
        public static Graphics drawArea;

        public static void DrawAll(object o)
        {
            Panel pnl = ((Panel)o);
            drawArea = pnl.CreateGraphics();

            DrawBackdrop();
            drawArea.Dispose();
        }

        public static void DrawBackdrop()
        {
            drawSky();
            drawTerrain();
            drawSun();
            drawTree();
            drawString();
        }

        public static void drawTerrain()
        {
            Brush brush = new HatchBrush(HatchStyle.Divot, Color.Green, Color.DarkGreen);
            drawArea.FillRectangle(brush, 0, 450, 745, 280);

            brush.Dispose();
        }

        public static void drawSky()
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 460),
                new Point(0, 0),
                Color.FromArgb(176, 196, 222),
                Color.FromArgb(135, 206, 250));

            drawArea.FillRectangle(brush, 0, 0, 745, 450);
            brush.Dispose();
        }

        public static void drawSun()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(600, 75, 100, 100);

            PathGradientBrush brush = new PathGradientBrush(path);

            brush.CenterPoint = new PointF(675, 100);
            brush.CenterColor = Color.Yellow;

            Color[] colors = { Color.Orange };
            brush.SurroundColors = colors;

            drawArea.FillEllipse(brush, 600, 75, 100, 100);

            path.Dispose();
            brush.Dispose();
        }

        public static void drawTree()
        {
            LinearGradientBrush trunk = new LinearGradientBrush(
                new Point(80, 0),
                new Point(0, 0),
                Color.Brown,
                Color.SandyBrown);

            drawArea.FillRectangle(trunk, 450, 350, 30, 150);
            trunk.Dispose();

            Brush leaves = new HatchBrush(HatchStyle.LargeConfetti, Color.ForestGreen, Color.DarkOliveGreen);
            drawArea.FillEllipse(leaves, 365, 200, 200, 200);
        }

        public static void drawString()
        {
            string myString = "Bring back Spring!";

            Font myFont = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Black);

            drawArea.DrawString(myString, myFont, brush, 20, 20);
        }
    }
}
