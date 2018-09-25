using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace FindSampleGame
{
    public partial class GameForm : Form
    {
        public GameForm(int gridX, int gridY)
        {
            InitializeComponent();

            MakeVisible(gridX, gridY);

            bool[,] gridMatrix = new bool[gridX, gridY];
            GenerateRandom(gridMatrix);
        }

        //Create dynamically sized grid based on input size
        private void MakeVisible(int x, int y)
        {
            for (int i = 0; i < y; i++) // Loops through number of Rows
            {
                for (int k = 0; k < x; k++) // Loops through number of Columns
                {
                    // Gather label data of controls used for grid
                    var yLabel = this.Controls.OfType<Label>().Where(txt => txt.Name.StartsWith("labelY" + i.ToString()));
                    var xLabel = this.Controls.OfType<Label>().Where(txt => txt.Name.StartsWith("labelX" + k.ToString()));
                    var button = this.Controls.OfType<Button>().Where(txt => txt.Name.StartsWith("ButtonX" + k.ToString() + "Y" + i.ToString()));

                    // Change visibility for all labels dynamically based on grid size
                    foreach (var Y in yLabel)
                        Y.Visible = true;
                    foreach (var X in xLabel)
                        X.Visible = true;
                    foreach (var B in button)
                        B.Visible = true;
                }
            }
        }

        private bool[,] GenerateRandom(bool [,] grid)
        {
            // Generate random numbers using random numbers as the seed
            // too ensure trully random numbers for both coordinates
            Random randomX = new Random(Guid.NewGuid().GetHashCode());
            Random randomY = new Random(Guid.NewGuid().GetHashCode());

            // Get maximum array size for loop
            int maxX = grid.GetLength(0);
            int maxY = grid.GetLength(1);
            
            // Set each instance in the matrix to false
            for (int i = 0; i < maxY; i++)
            {
                for (int k = 0; k < maxX; k++)
                {
                    grid[k,i] = false;
                }
            }

            // Generate random location in matrix for the "key"
            int randX = randomX.Next(0, maxX);
            int randY = randomY.Next(0, maxY);
            grid[randX, randY] = true;
            MessageBox.Show("Random Location Set Too: \n[" + randX.ToString() + "," + randY.ToString() + "]");   // For testing random generator

            return grid;
        }
    }
}
