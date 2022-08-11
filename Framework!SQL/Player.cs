﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player : Weapon
    {
        public Player(Weapon weapon)
        {
            Money = 0;
            Hp = 100;
            Strenght = 5;
            Dmg = Strenght + weapon.Dmg;
            
        }
        public Player()
        {
            Money = 0;
            Hp = 100;
            Strenght = 5;
            Dmg = Strenght;
        }
        public int Money;
        public int Hp = 100;
        private int Strenght;
        public int Dmg;
    }
}
