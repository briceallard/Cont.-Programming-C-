/**********************************************************
 * Author: Brice Allard
 * Program: FindEvidence
 * Date: 10/01/2018
 * Class: Utilities
 * Description: Helper class to hold all of my CONST values
 *  and assist in providing some functionality.
***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvidence
{
    class Utilities
    {
        // Member Data
        private static readonly int CLUES_MAX = 4;
        private static readonly Random random = new Random(Guid.NewGuid().GetHashCode());

        // Properties
        public static string CLUE_FOUND_TITLE
        {
            get
            {
                return "Clue Found!"
            }
        }
        
        // Methods
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
