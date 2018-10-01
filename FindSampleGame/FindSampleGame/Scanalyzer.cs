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

using System;
using System.Windows.Forms;

namespace FindSampleGame
{
    class Scanalyzer
    {
        // Mamber data
        static readonly int CLUES = 2;
        private bool[,] gridMatrix;
        private Clue clue;

        // Cosntructor
        public Scanalyzer(int gridX, int gridY)
        {
            gridMatrix = new bool[gridX, gridY];
            GenerateRandom(gridMatrix);
        }

        // Generate random locations for the clues
        private void GenerateRandom(bool[,] grid)
        {
            // Generate random numbers using random numbers as the seed
            // too ensure trully random numbers for both coordinates
            Random randomX = new Random(Guid.NewGuid().GetHashCode());
            Random randomY = new Random(Guid.NewGuid().GetHashCode());

            // Get maximum array size for loop
            int maxX = grid.GetLength(0);
            int maxY = grid.GetLength(1);
                
            // Generate random location in matrix for the "key"
            int randX = randomX.Next(0, maxX);
            int randY = randomY.Next(0, maxY);

            if (!grid[randX, randY])
            {
                grid[randX, randY] = true;
                clue = new Clue(randX, randY);
                // MessageBox.Show("Random Location Set Too: \n[" + randX.ToString() + "," + randY.ToString() + "]");   // For testing random generator
            }
        }

        // Is the user guess == to clue
        private bool isMatch(Guess guess, Clue key)
        {
            return (guess.getX() == key.getX() && guess.getY() == key.getY()) ? true : false;
        }

        // Display if user found clue or not
        public bool EvaluateGuess(Guess guess, int guessCount)
        {
            string notFound = "Clue NOT Found ...";
            string notCaption = "Try Again!";
            string found = "Clue found ...";
            string foundCaption = "Good job!";

            //Not found
            if (!isMatch(guess, clue))
            {
                MessageBox.Show(notFound, notCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            else // Was found
            {
                MessageBox.Show(found, foundCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return true;
            }
        }

        // If clue not found, generate hint instead
        public string GenerateHint(Guess guess, int guessCount)
        {
            if (guessCount % 2 == 0)
                return guess.getX() > clue.getX() ? "^" : "v";
            else
                return guess.getY() > clue.getY() ? "<" : ">";
        }
    }
}
