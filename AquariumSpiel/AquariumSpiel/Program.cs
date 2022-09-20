using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 50;
            string[,] aquarium = new string[y, x];
            for (int j = 0; j < x; j++)
            {
                for (int i = 0; i < y; i++)
                {
                    if (i == 0 || i == y - 1)
                    {
                        aquarium[i, j] = "|";
                    }
                    else
                    {
                        aquarium[i, j] = " ";
                    }
                    if (j == x-1)
                    {
                        aquarium[i, j] = "-";
                    }
                    
                }
            }
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        Console.Write(aquarium[i, j]);
                    }
                    //\n bedeutet es wird eine neue Zeile angebrochen
                    Console.Write("\n");
                }
                Console.ReadLine();
            
        }
    }
}
