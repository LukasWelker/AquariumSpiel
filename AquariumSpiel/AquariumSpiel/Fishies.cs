using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public abstract class Fishies
    {
        //Properties
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public string Shape { get; set; }
        public string ReverseShape { get; set; }
        public double ChangeDepthProb { get; set; }
        public string Direction { get; set; }
        public int Speed { get; set; }

        //Hier definiere ich, welche Parameter der Methode übergeben werden!
        public void Swim(string[,] AquariumBecken)
        {

            if (Direction == "left")
            {
                if (PositionX == 2)
                {
                    Direction = "right";
                }
                else
                {
                    PositionX -= Speed;
                }


            }
            else
            {
                if(PositionX == AquariumBecken.GetLength(1) - 2)
                {
                    Direction = "left";
                }
                PositionX += Speed;
            }
            


        }



    }
}
