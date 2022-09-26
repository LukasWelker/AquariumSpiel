using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public class Blowfish : Fishies
    {
        public Blowfish(int positiony, int positionx)
        {

            PositionX = positionx;
            PositionY = positiony;
            Shape = "><()>";
            ReverseShape = "<()><";
            ChangeDepthProb = 1;
            Direction = "left";
            Speed = 1;
        }
    }
}
