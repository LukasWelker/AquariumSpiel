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
        public void Swim(string[,] AquariumBecken,string usersWish)
        {
            ChangeDepth(AquariumBecken);
            //Wir überprüfen auf die Richtung und die PositionX in Abhänigkeit der Fischlänge sowie dea Aquariums
            if (Direction == "right" && PositionX + Shape.Length >= AquariumBecken.GetLength(1) - 2)
            {
                //Richtung wird gewechselt zu links
                Direction = "left";
                //Shape wird umgewandelt (Spiegelverkehrt)
                Shape = ReverseShape;
            }
            //Wir überprüfen auf die Richtung und auf die Position in Abhängigkeit der Geschwindigkeit
            else if (Direction == "left" && PositionX <= 1 + Speed )
            {
                //Richtung wird gewechselt
                Direction = "right";
                //Shape wird umgewandelt zu ursprünglichen Shape
                Shape = ShapeChange;
            }
            //Bestimmt, das wenn Richtung rechts gilt, der Fisch nach rechts schwimmt und der Index von PositionX größer
            //wird um den individuellen Wert Speed
            if (Direction == "right")
            {
                PositionX += Speed;
            }
            //Bestimmt, das wenn Richtung links gilt, der Fisch nach links schwimmt und der Index von PositionX kleiner
            //wird um den individuellen Wert Speed
            else
            {
                PositionX -= Speed;
            }

            //Provisorische Strömung
            if(usersWish == "y")
            {
                Random r = new Random();
                int random = r.Next(0, 10);
                if (Direction == "left" && random <= 5)
                {
                    Direction = "right";
                }
                if (Direction == "right" && random > 5)
                {
                    Direction = "left";
                }
            }
            

            
        }
        public void ChangeDepth(string[,] AquariumBecken)
        {
            int randomX = 2;
            //Random.Next generiert nur Upperboundzahlen ==> letzter index wird nie generiert
            int randomNumber = random.Next(0, randomX);
            //wenn rN = randomX und PositionY>0 (bedeutet irgendeine Position zwischen Height des Aquariums und 0
            if(randomNumber == randomX - 1 && PositionY > 0)
            {
                // Fisch schwimmt nach oben aber Index der PositionY wird kleiner
                PositionY--;
            }
            //(AquariumBecken.GetLength(0) beschreibt die y-Achse
            //Wenn y-Achse größer als die IndexPositionY+2 des Fisches dann erfolgt siehe Z.74
            else if (AquariumBecken.GetLength(0) > PositionY + 2)
            {
                //Fisch schwimmt nach unten aber Index der PositionY wird größer
                PositionY++;
            }
            else
            {
                //Position des Fisches sowie Index bleiben unverändert.
                PositionY = PositionY;
            }

        }
       
    }
}
