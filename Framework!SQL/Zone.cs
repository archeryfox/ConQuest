using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Framework_SQL
{
    internal struct Zone
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ZoneId { get; set; }
        public string[,] Map;
        static public string[,] Init(int ZoneHeight, int ZoneWidth)
        {
            return new string[ZoneHeight, ZoneWidth];
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
