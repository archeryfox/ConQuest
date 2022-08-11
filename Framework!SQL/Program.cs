﻿using System;


namespace Framework_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Zone _zone = new Zone();
            _zone.Name = "Tutorial Room";
            _zone.ZoneId = 1;
            var zone = Zone.Init(9, 16);
            bool EnemyDead = false;
            bool TalkToNPC = false;
            int EnemyHp = 50;
            int EnemyDmg = 15;
            var Sword = new Sword();
            var Shield = new Shield();
            Player player = new Player();
            var IsFight = false;
            dynamic[] invenetary = { Sword, null };

            //Спавн игрока
            int y = 2, x = 5;
            bool isSolid;
            //Буфер
            int yb = y, xb = x;

            while (true)
            {
                isSolid = zone[y, x] == " #" || zone[y, x] == " |" || zone[y, x] == "| "
                       || zone[y, x] == "__" || zone[y, x] == "|_" || zone[y, x] == "_|" || zone[y, x] == " Ш";
                if (isSolid)
                {
                    y = yb;
                    x = xb;
                }
                
                if (zone[y, x] == " ?")
                {
                    y = yb;
                    x = xb;
                    TalkToNPC = true;
                    if (EnemyDead == false)
                    {
                        Console.WriteLine("Здравствуй путник! Меня зовут Витя! Что привело тебя в эти темные и непроглядные пучины подземелья?");
                        Console.WriteLine("Помоги мне убить монстра и я тебя вознагражу! Для начала тебе нужно купить оружие. Держи 70 монет для покупки меча.");
                        player.Money = player.Money + 70;
                        Console.WriteLine($"У вас теперь {player.Money} монет.");
                    }
                    else if (EnemyDead == true)
                    {
                        Console.WriteLine("Ты убил его! Огромное тебе спасибо. Вот, возьми это в качестве платы.");
                        Console.WriteLine("Вы получили 150 золотых монет!");
                        player.Money = player.Money + 150;
                        Console.WriteLine($"У вас теперь {player.Money} монет.");
                    }
                }
                if (zone[y, x] == " X")
                {
                    y = yb;
                    x = xb;
                    if (TalkToNPC == false)
                    {
                        Console.WriteLine("Вы встретили монстра! Он опасен, лучше не драться с ним без причины.");
                    }
                    if (TalkToNPC == true)
                    {
                        Console.WriteLine("Вы встретили монстра, о котором говорил Витя!");
                        IsFight = true;
                        while ((player.Hp > 0 && EnemyHp > 0) && IsFight)
                        {

                            Console.WriteLine("W - Уйти, A - Атака оружием, D - Исцеление, S - Пропуск хода.");
                            ConsoleKeyInfo fki = Console.ReadKey(true);

                            switch (fki.Key)
                            {
                                case ConsoleKey.W:
                                    y--;
                                    IsFight = false;
                                    break;
                                case ConsoleKey.D:
                                    player.Hp = player.Hp + player.Dmg - EnemyDmg;
                                    if (player.Hp > 100)
                                    {
                                        player.Hp = 100;
                                    }
                                    Console.WriteLine($"Вы вылечились! Но враг нанёс вам {EnemyDmg}. Ваше здоровье - {player.Hp}.");
                                    break;
                                case ConsoleKey.A:
                                    player.Hp = player.Hp - EnemyDmg;
                                    EnemyHp = EnemyHp - player.Dmg;
                                    Console.WriteLine($"Ваше здоровье - {player.Hp}.");
                                    Console.WriteLine($"Здоровье врага - {EnemyHp}.");
                                    break;
                                case ConsoleKey.S:
                                    player.Hp = player.Hp - EnemyDmg;
                                    Console.WriteLine($"Ваше здоровье - {player.Hp}.");
                                    Console.WriteLine($"Здоровье врага - {EnemyHp}.");
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (player.Hp > 0 && EnemyHp <= 0)
                        {
                            Console.WriteLine($"Ура, победа!");
                            IsFight = false;
                            EnemyDead = true;
                        }
                        else if (player.Hp <= 0 && EnemyHp > 0)
                        {
                            Console.WriteLine("Вы сдохли как собака. Позор вам.");
                            IsFight = false;
                        }
                        else
                        {
                            Console.WriteLine("Вы успешно сбежали.");
                            IsFight = false;
                        }
                    }
                }


                //Перезапись буфера
                yb = y;
                xb = x;

                //Создание поля / get
                _zone.RenderPlayer(zone, y, x);
                //Заполнение поля / set
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

                //Управление
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.S:
                        y++;
                        break;
                    case ConsoleKey.W:
                        y--;
                        break;
                    case ConsoleKey.D:
                        x++;
                        break;
                    case ConsoleKey.A:
                        x--;
                        break;
                    default:

                        break;
                }

                Console.Clear();
            }

        }
    }
}