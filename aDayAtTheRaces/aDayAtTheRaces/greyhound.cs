using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    public class greyhound
    {
        public int StartingPostition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            int [] moveForward = new int[4];
            moveForward[0] = Location + 1;
            moveForward[1] = Location + 2;
            moveForward[2] = Location + 3;
            moveForward[3] = Location + 4;

            if (Location < RacetrackLength)
            {
                Location += moveForward[Randomizer.Next(moveForward.Length)];
                MyPictureBox.Left = StartingPostition + Location;
                
            }
            else { return true; }

        }
        
    }
}
