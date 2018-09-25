using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindSampleGame
{
    public partial class GridSizeForm : Form
    {
        public GridSizeForm()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Inline declaration of int gridX and int gridY during int parse for grid size
            if (!Int32.TryParse(textBoxX.Text, out int gridX) || !Int32.TryParse(textBoxY.Text, out int gridY))
            {
                MessageBox.Show("Error: Grid Size Must Contain Integers Only!");
            }
            else if (!ValidateGrid(gridX, gridY))
            {
                MessageBox.Show("Error: Grid Size Exceeded!");
            }
            else
            {
                GameForm myForm = new GameForm(gridX, gridY);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        // Verifies user input for grid size is properly formatted
        private bool ValidateGrid(int x, int y)
        {
            return TestRange(x, y) ? true : false;
        }

        // Verify that user input for grid size is withing accepted range.
        private bool TestRange (int x, int y)
        {
            return (x >= 1 && x <= 10 && y >= 1 && y <= 10) ? true : false;
        }

        // Simple function to clear the contents of the Grid Size
        private void ButtonClr_Click(object sender, EventArgs e)
        {
            textBoxX.Text = "";
            textBoxY.Text = "";
        }
    }
}
