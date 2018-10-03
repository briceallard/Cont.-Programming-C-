/**********************************************************
 * Author: Brice Allard
 * Program: FindEvidence
 * Date: 10/01/2018
 * Class: Clue
 * Description: Parent class as to which all pieces of
 *  evidence will inheret from.
***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvidence
{
    public abstract class Clue
    {
        // Private Member Data
        private readonly int x;
        private readonly int y;
        private bool found;

        // Default Constructor
        public Clue()
        {
            x = y = 0;
            found = false;
        }

        // Parametrized Constructor
        public Clue(int x, int y)
        {
            this.x = x;
            this.y = y;
            found = false;
        }

        // Property get/set for X value
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                X = value;
            }
        }

        // Property get/set for X value
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                Y = value;
            }
        }

        // Propert get/set for found bool
        public bool Found
        {
            get
            {
                return found;
            }
            set
            {
                Found = value;
            }
        }

        public abstract string FoundStr();
    }
}
