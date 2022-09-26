using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu deinem eigenem Aquariumspiel!");
            Console.WriteLine(" ");
            Console.WriteLine("Wähle wie hoch dein Aquarium sein soll (es muss mindestens 20 hoch sein)!");
            int UsersHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wähle wie breit dein Aquarium sein soll (es muss mindestens 50 lang sein)!");
            int UsersWidth = Convert.ToInt32(Console.ReadLine());


            Aquarium aquarium1 = new Aquarium(UsersHeight, UsersWidth);
            aquarium1.AddFish();
            
            while (true)
            {
                Console.Clear();
                aquarium1.LetFishesSwim();
                aquarium1.PrintAquarium();
                Thread.Sleep(1000);
            }
           

            Console.ReadLine();
            
        }
    }
}
