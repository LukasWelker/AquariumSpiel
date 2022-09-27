using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    public abstract class Fishies
    {
        public static Random random = new Random();
        //Properties
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public string Shape { get; set; }
        public string ShapeChange { get; set; }
        public string ReverseShape { get; set; }
        public int ChangeDepthProb { get; set; }
        public string Direction { get; set; }
        public int Speed { get; set; }

        //Hier definiere ich, welche Parameter der Methode übergeben werden!
        public void Swim(string[,] AquariumBecken)
        {
            ChangeDepth(AquariumBecken);
            //Wir überprüfen auf die Richtung und die PositionX in Abhänigkeit der Fischlänge sowie dea Aquariums
            if (Direction == "right" && PositionX + Shape.Length >= AquariumBecken.GetLength(1) - 2)
            {
                Direction = "left";
                Shape = ReverseShape;
            }
            //Wir überprüfen auf die Richtung und auf die Position in Abhängigkeit der Geschwindigkeit
            else if (Direction == "left" && PositionX <= 1 + Speed )
            {
                Direction = "right";
                Shape = ShapeChange;
            }

            if (Direction == "right")
            {
                PositionX += Speed;
            }
            else
            {
                PositionX -= Speed;
            }

            
        }
        public void ChangeDepth(string[,] AquariumBecken)
        {
            int randomX = 2;
            int randomNumber = random.Next(0, randomX);
            if(randomNumber == randomX - 1 && PositionY > 0)
            {
                PositionY--;
            }
            else if (AquariumBecken.GetLength(0) > PositionY + 2)
            {
                PositionY++;
            }
            else
            {
                PositionY = PositionY;
            }

        }


    }
}
