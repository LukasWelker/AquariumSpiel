using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public class Carp : Fishies
    {
        //Konstruktor
        public Carp(int positiony, int positionx)
        {
           
            PositionX = positionx;
            PositionY = positiony;
            Shape = "><>";
            ShapeChange = "><>";
            ReverseShape = "<><";
            ChangeDepthProb = 2;
            Direction = "right";
            Speed = 2;
        }

    }
}
