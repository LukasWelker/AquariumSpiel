using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public class Shark : Fishies
    {
        public Shark(int positiony, int positionx)
        {
            PositionX = positionx;
            PositionY = positiony;
            Shape = "><===///>";
            ReverseShape = "<///===><";
            ChangeDepthProb = 2.5;
            Direction = "left";
            Speed = 2;
        }
    }
}
