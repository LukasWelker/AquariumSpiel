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
        public int Height {get; set;}
        public int Width {get; set;}
        public List<Fishies> Fishes {get; set;}
        //[,] MultidimesionalesArray
        public string[,] AquariumBecken {get; set;}
        

        public Aquarium(int height, int width)
        {
            Fishes = new List<Fishies>();
            
            AquariumBecken = new string[height, width];
            Height = height;
            Width = width;
        }
      
        public void AddFish()
        {
            Fishes.Add(new Carp(10, 9));
            Fishes.Add(new Shark(14, 40));
            Fishes.Add(new Blowfish(6, 27));
            Fishes.Add(new Swordfish(4, 18));
        }
        public void PrintAquarium()
        {
        
            for (int j = 0; j < AquariumBecken.GetLength(0); j++)
            {
                for (int i = 0; i < AquariumBecken.GetLength(1); i++)
                {
                    if (i == 0 || i == AquariumBecken.GetLength(1)- 1)
                    {
                        AquariumBecken[j, i] = "|";
                    }
                    else
                    {
                        AquariumBecken[j,i] = " ";
                    }
                    if (j == AquariumBecken.GetLength(0) - 1)
                    {
                        AquariumBecken[j, i] = "-";

                    }
                }
            }
            foreach (Fishies f in Fishes)
            {
                int x = f.PositionX;
                if (x + f.Shape.Length < Width)
                {
                    for (int i = 0; i < f.Shape.Length; i++)
                    {
                        AquariumBecken[f.PositionY, x + i] = f.Shape[i].ToString();
                       
                    }
                }
                else{
                    Console.Write($"{f.GetType().Name} ist zu weit");
                }
            }


            for (int j = 0; j < AquariumBecken.GetLength(0); j++)
            {
                for (int i = 0; i < AquariumBecken.GetLength(1); i++)
                {
                    Console.Write(AquariumBecken[j, i]);
                }
                //\n bedeutet es wird eine neue Zeile angebrochen
                Console.Write("\n");
            }
        }
        public void LetFishesSwim()
        {
            foreach(Fishies f in Fishes)
            {
                //Hier übergebe ich der Methode ein Parameter
                f.Swim(AquariumBecken);
            }
        }
       
        
    }
}
