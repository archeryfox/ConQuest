using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_SQL
{
    internal class Weapon
    {
        int Def { get; set; }
        int SwordDmg = 15;
        int BowDmg = 12;
        int BowDef = 5;
        int Shield = 5;
        int ShieldDef = 18;
    }

    class Sword : Weapon
    {
        public int Def;
        
        public int Dmg;
        static Sword()
        {
            Console.WriteLine("Меч бога!");
        }
        
    }
    class Shield : Weapon
    {
        private int def = 15;

        public int Def
        {
            get { return def; }
            private set {  }
        }

        public int Dmg { get; private set; }
    }
    class Bow : Weapon
    {
        



    }
}