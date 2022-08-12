using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Weapon
    {
        int Def { get; set; }
        public int Dmg { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }

    class Sword : Weapon
    {
        public int Def ;

        private int dmg;

        public int Dmg
        {
            get { return dmg; }
            private set { dmg = 15; }
        }

        
    }
    class Shield : Weapon
    {
        private int def;

        public int Def
        {
            get { return def; }
            private set { def = 15; }
        }

        private int dmg;

        public int Dmg
        {
            get { return dmg; }
            set { dmg = 2; }
        }

    }
    class Bow : Weapon
    {
        private int def;

        public int Def
        {
            get { return def; }
            private set { def = 5; }
        }

        private int dmg;

        public int Dmg
        {
            get { return dmg; }
            set { dmg = 12; }
        }

    }
}