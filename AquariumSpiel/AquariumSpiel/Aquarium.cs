using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    //Abstract bedeuetet es kann kein Objekt hiervon erstellt werden
    public class Aquarium
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Fishies> Fishes { get; set; }
        //[,] MultidimesionalesArray
        public string[,] AquariumBecken { get; set; }
        public string UsersWish { get; set; }

        public Aquarium(int height, int width, string userswish)
        {
            Fishes = new List<Fishies>();

            AquariumBecken = new string[height, width];
            Height = height;
            Width = width;
            UsersWish = userswish;
        }

        public void AddFish()
        {
            Fishes.Add(new Carp(10, 9));
            Fishes.Add(new Shark(14, 20));
            Fishes.Add(new Blowfish(6, 27));
            Fishes.Add(new Swordfish(4, 18));
            Fishes.Add(new Carp(5, 22));
            Fishes.Add(new Carp(4, 21));
        }
        public void PrintAquarium()
        {            
            for (int j = 0; j < AquariumBecken.GetLength(0); j++)
            {
                for (int i = 0; i < AquariumBecken.GetLength(1); i++)
                {
                    if (i == 0 || i == AquariumBecken.GetLength(1) - 1)
                    {
                        AquariumBecken[j, i] = "|";
                    }
                    else
                    {
                        AquariumBecken[j, i] = "~";
                    }
                    if (j == AquariumBecken.GetLength(0) - 1)
                    {
                        AquariumBecken[j, i] = "-";
                    }
                }
            }
            foreach (Fishies f in Fishes)
            {
                for (int i = 0; i < f.Shape.Length; i++)
                {
                    AquariumBecken[f.PositionY, f.PositionX + i] = f.Shape[i].ToString();

                }
            }

            for (int j = 0; j < AquariumBecken.GetLength(0); j++)
            {
                for (int i = 0; i < AquariumBecken.GetLength(1); i++)
                {
                    if (AquariumBecken[j, i] == "~")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(AquariumBecken[j, i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //\n bedeutet es wird eine neue Zeile angebrochen
                Console.Write("\n");
            }
        }
        public void LetFishesSwim()
        {
            foreach (Fishies f in Fishes)
            {
                //Hier übergebe ich der Methode ein Parameter
                f.Swim(AquariumBecken, UsersWish);
            }
        }


    }
}
