using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Zone
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ZoneId { get; set; }
        public string[,] Map;
        static public string[,] Init(int ZoneHeight, int ZoneWidth)
        {
            return new string[ZoneHeight, ZoneWidth];
        }
        public void RenderZone1(string[,] zone, int y, int x)
        {
            for (int i = 0; i < zone.GetUpperBound(0) + 1 /* y */; i++)
            {
                zone[i, 0] = "| ";
                zone[i, 15] = " |";

                for (int j = 0; j < zone.GetUpperBound(1) + 1 /* x */; j++)
                {
                    zone[0, j] = "__";
                    zone[8, j] = "__";
                    switch (i, j)
                    {
                        case (3, 4 and < 6):
                        case (3, 6):
                        case (3, 5):
                        case (4, 5):
                            zone[i, j] = " #";
                            break;
                        case (4, 6):
                            zone[i, j] = " ?";
                            break;
                        case (7, 13):
                            zone[i, j] = " X";
                            break;
                        case (5, 9):
                            zone[i, j] = " Ш";
                            break;
                        case (2, 14):
                            zone[i, j] = " M";
                            break;
                        case (8, 0):
                            zone[i, j] = "|_";
                            break;
                        case (8, 15):
                            zone[i, j] = "_|";
                            break;
                        default:
                            break;
                    }
                    Console.Write($" {zone[i, j]}");
                }
                Console.WriteLine("");
            }

        }
        public void RenderPlayer(string[,] zone,int y, int x)
        {
            for (int i = 0; i < zone.GetUpperBound(0) + 1/* y */; i++)
            {
                for (int j = 0; j < zone.GetUpperBound(1) + 1/* x */; j++)
                {
                    if (y < zone.GetUpperBound(0) + 1 && x < zone.GetUpperBound(1) + 1) // Игрок
                    {
                        zone[y, x] = " @";
                    }
                    zone[i, j] = " .";
                }
            }
        }
    }
}
