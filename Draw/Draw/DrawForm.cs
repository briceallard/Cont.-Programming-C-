using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
/**
 * Brice Allard
 * Contemporary Programming - C#
 * Dr. Stringfellow
 * 11-13-2018
 * 
 * Basic program to desmonstrate the drawing methods
 **/

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Backdrop.DrawAll(PNL_Draw);
            StickFigure.DrawAll(PNL_Draw);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw();
        }
    }
}
