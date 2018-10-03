using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvidence
{
    class Fingerprint : Clue
    {
        // Member data - NONE YET

        // Default Constructor
        public Fingerprint()
        {
            X = Y = 0;
            Found = false;
        }

        // Parameterized Constructor
        public Fingerprint(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Found = false;
        }

        // Methods

        // Default string returned when found
        public override string FoundStr()
        {
            return $"Found Fingerprint at [{X},{Y}]!";
        }
    }
}
