using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRacing_Assignment
{
    class player
    {

        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is
        public string name;  //name of the player/racer
        public PictureBox MyPictureBox; // My PictureBox object
        public int Location; // My Location on the racetrack
        public bool RaceWinner = false;

        public Random myRandom = new Random(); // An instance of Random

        public player(string Name, PictureBox pBox, int TrackLength, int StartPosition)
        {
            MyPictureBox = pBox;
            RacetrackLength = TrackLength;
            StartingPosition = StartPosition;
            name = Name;
        }

        public bool Run(int distance)
        {
            // the point of my PictureBox on the form
            Point p = MyPictureBox.Location;

            //random distance for the player
            //    int distance = myRandom.Next(0,15);

            MoveMyPictureBox(distance);

            Location += distance;

            if (Location >= 900)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void MoveMyPictureBox(int distance)
        {

            //moving the picturebox
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }


        public void TakeStartingPosition()
        {

            //MoveMyPictureBox(-Location);
            //Location = 56;
            MyPictureBox.Left = 56;

        }



    }
}
