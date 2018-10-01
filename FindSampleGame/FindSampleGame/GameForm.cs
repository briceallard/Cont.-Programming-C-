//****************************************************************************
// Program Name: Find The Evidence
// Files: Clue.cs, Guess.cs, Scanalyzer.cs, GameForm.cs, GridSizeForm.cs

// Author: Brice Allard
// Email: briceallard@gmail.com
// Description:
//	- Using a Windows form and C# design and program a game like application
//  - where the user must locate a peice of evidence in a matrix of hidden
//  - locations and output the user interactions via Message Box.
//****************************************************************************

using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace FindSampleGame
{
    public partial class GameForm : Form
    {
        // Member variables
        private Scanalyzer scanalyzer;
        private int found;
        public int guessCount;

        // Initialize the Game Form and set visiblility
        public GameForm(int gridX, int gridY)
        {
            InitializeComponent();

            found = guessCount = 0;

            MakeVisible(gridX, gridY);
            scanalyzer = new Scanalyzer(gridX, gridY);
        }

        //Create dynamically sized grid based on input size
        private void MakeVisible(int x, int y)
        {
            for (int i = 0; i < x; i++) // Loops through number of Rows
            {
                for (int j = 0; j < y; j++) // Loops through number of Columns
                {
                    // Gather label data of controls used for grid
                    var xLabel = this.Controls.OfType<Label>().Where(txt => txt.Name.StartsWith("labelX" + i.ToString()));
                    var yLabel = this.Controls.OfType<Label>().Where(txt => txt.Name.StartsWith("labelY" + j.ToString()));
                    var button = this.Controls.OfType<Button>().Where(txt => txt.Name.StartsWith("ButtonX" + i.ToString() + "Y" + j.ToString()));

                    // Change visibility for all labels dynamically based on grid size
                    foreach (var X in xLabel)
                        X.Visible = true;
                    foreach (var Y in yLabel)
                        Y.Visible = true;
                    foreach (var B in button)
                        B.Visible = true;
                }
            }
        }

        // Button click operation for evidence locations
        private void Guess_Click(object sender, EventArgs e)
        {
            guessCount++;

            int[] coords = GetButtonLocation(sender);
            Guess guess = new Guess(coords[0], coords[1]);
            var button = (Button)sender;

            if (scanalyzer.EvaluateGuess(guess, guessCount))
            {
                found++;
                CluesFnd_Label.Text = found.ToString();
                button.Text = "X";
            }
            else
            {
                GuessCnt_Label.Text = guessCount.ToString();
                button.Text = scanalyzer.GenerateHint(guess, guessCount);
            }
        }

        // Return location of button in x,y format
        private int[] GetButtonLocation(object sender)
        {
            int[] location = new int[2];
            string name = ((Button)sender).Name;

            location[0] = (int)Char.GetNumericValue(name, 7);
            location[1] = (int)Char.GetNumericValue(name, 9);
            // MessageBox.Show("Button Clicked: \n[" + location[0].ToString() + "," + location[1].ToString() + "]");   // For testing random generator

            return location;
        }

        // Button click to close application
        private void Quit_Button_Click(object sender, EventArgs e)
        {
            const string message = "Would you like to exit?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption,
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Button click to restart game
        private void Restart_Button_Click(object sender, EventArgs e)
        {
            const string message = "Would you like to restart?";
            const string caption = "Restart";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
    }
}
