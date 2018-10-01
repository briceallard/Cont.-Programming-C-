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

namespace FindSampleGame
{
    // Class to maintain user Guess data
    class Guess
    {
        // Member data
        private readonly int x;
        private readonly int y;

        // Default Constructor
        public Guess()
        {
            x = y = 0;
        }
        
        // Overloaded Constructor
        public Guess(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Return X coordinate value
        public int getX()
        {
            return x;
        }

        // return Y coordinate value
        public int getY()
        {
            return y;
        }
    }
}
