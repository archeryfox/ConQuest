﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_SQL
{
    internal class Player : Weapon
    {
        public Player(Sword sword)
        {
            Money = 0;
            Hp = 100;
            Strenght = 5;
            Dmg = Strenght + sword.Dmg;
            
        }
        public Player()
        {
            Money = 0;
            Hp = 100;
            Strenght = 5;
            Dmg = Strenght;
        }
        public int Money;
        private int hp;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private static int Strenght;
        public int Dmg;
        void Quest()
        {

        }
    }
}