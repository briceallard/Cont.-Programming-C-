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
    // Class that holds Clue data
    class Clue
    {
        // Member data 
        private readonly int x;
        private readonly int y;

        // Default Constructor
        public Clue()
        {
            x = y = 0;
        }

        // Overloaded Constructor
        public Clue(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // return X coordinate value
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
