using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public class Swordfish : Fishies
    {
        public Swordfish(int positiony, int positionx)
        {
            PositionX = positionx;
            PositionY = positiony;
            Shape = "><>-";
            ShapeChange = "><>-";
            ReverseShape = "-<><";
            ChangeDepthProb = 5;
            Direction = "right";
            Speed = 1;
        }
       
    }
}
