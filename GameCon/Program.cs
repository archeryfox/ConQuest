﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GameCon
{
    internal class Program
    {
    static void Main(string[] args)
        {
            
            bool IsTalk = false;
            int Heal = 40;
            bool Book = false;
            bool ChestOpen = false;
            int Potion = 0;
            int ArmorDef = 0;
            int LightDef = 5;
            int HeavyDef = 12;
            int Money = 0;
            int Weapon = 0;
            int WeaponDmg = 0;
            int WeaponDef = 0;
            int SwordDef = 0;
            int SwordDmg = 15;
            int BowDmg = 12;
            int BowDef = 5;
            int ShieldDmg = 5;
            int ShieldDef = 12;
            string[,] zone = new string[9, 16];
            Zone _proto_zone = new Zone();
            bool EnemyDead = false;
            bool TalkToNPC = false;
            int EnemyHp = 50;
            int PlayerHp = 100;
            int EnemyDmg = 15;
            int PlayerDmg = 5 + Weapon;
            var IsFight = true;
            dynamic[] Invenetary = { Money, Weapon };

            //Спавн игрока
            int y = 2, x = 5;
            bool isSolid;
            //Буфер
            int yb = y, xb = x;

            while (true)
            {
                isSolid = zone[y, x] == " #" || zone[y, x] == " |" || zone[y, x] == "| "
                        || zone[y, x] == "__" || zone[y, x] == "|_" || zone[y, x] == "_|" || zone[y, x] == " Ш";
                void Solid(int y, int x, int yb, int xb)
                {
                    y = yb;
                    x = xb;
                }
                if (isSolid)
                {
                    y = yb;
                    x = xb;
                }

                if (zone[y, x] == " Ш" && isSolid)
                {
                    if (ChestOpen == false)
                    {
                        Console.WriteLine("Перед вами сундук. Вы открываете его.");
                        Console.WriteLine("Внутри не было ничего кроме старой пыльной книги под названием Утопия. Вы взяли ее с собой.");
                        ChestOpen = true;
                        Book = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы уже открывали этот сундук. Теперь он пуст.");
                    }
                }
                if (zone[y, x] == " M")
                {
                    y = yb;
                    x = xb;
                    IsTalk = true;
                    if (Book == true && IsTalk == true)
                    {
                        Console.WriteLine("Здравствуй, приключенец! Проходи, посмотри на мои товары.");
                        Console.WriteLine("Я чую ауру книги у тебя в рюкзаке. Я куплю ее за 300 монет.\nY - Принять N - Отказ");
                        ConsoleKeyInfo BookSell = Console.ReadKey(true);
                        switch (BookSell.Key)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Спасибо. Вот твои деньги.");
                                Money = Money + 300;
                                Console.WriteLine($"У вас теперь {Money} монет.");
                                Book = false;
                                IsTalk = false;
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("Ну пожалуйста! Давай я дам 340 монет!\n\tY - Принять N - Отказ");
                                ConsoleKeyInfo Torg = Console.ReadKey(true);
                                switch (Torg.Key)
                                {
                                    case ConsoleKey.Y:
                                        Console.WriteLine("Ну вот! Так бы сразу! С вами приятно иметь дело.");
                                        Money = Money + 340;
                                        Console.WriteLine($"У вас теперь {Money} монет.");
                                        IsTalk = false;
                                        Book = false;
                                        break;
                                    case ConsoleKey.N:
                                        Console.WriteLine("Эх, зря вы так, я ведь предложил хорошую цену!");
                                        IsTalk = false;
                                        break;
                                }
                                break;
                            default: return;
                        }
                    }
                    if (Book == false && IsTalk == true)
                    {
                        Console.WriteLine("Привет! Хочешь что-нибудь купить?");
                        Console.WriteLine($"Ваш баланс - {Money} монет.");
                        Console.WriteLine("Легкие доспехи - 150(A), Тяжелые доспехи - 350(S), Щит - 150(D)");
                        Console.WriteLine("Лук - 100(F), Меч - 80(G), Зелье Исцеления - 30(H)");
                        ConsoleKeyInfo BuyMenu = Console.ReadKey(true);
                        switch (BuyMenu.Key)
                        {
                            case ConsoleKey.A:
                                if (Money >= 150)
                                {
                                    Money = Money - 150;
                                    Console.WriteLine($"Вы купили Легкие доспехи! У вас осталось {Money} монет.");
                                    ArmorDef = LightDef;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            case ConsoleKey.S:
                                if (Money >= 350)
                                {
                                    Money = Money - 350;
                                    Console.WriteLine($"Вы купили Тяжелые доспехи! У вас осталось {Money} монет.");
                                    ArmorDef = HeavyDef;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            case ConsoleKey.D:
                                if (Money >= 150)
                                {
                                    Money = Money - 150;
                                    Console.WriteLine($"Вы купили Щит! У вас осталось {Money} монет.");
                                    WeaponDef = ShieldDef;
                                    WeaponDmg = ShieldDmg;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            case ConsoleKey.F:
                                if (Money >= 100)
                                {
                                    Money = Money - 100;
                                    Console.WriteLine($"Вы купили Лук! У вас осталось {Money} монет.");
                                    WeaponDef = BowDef;
                                    WeaponDmg = BowDmg;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            case ConsoleKey.G:
                                if (Money >= 80)
                                {
                                    Money = Money - 80;
                                    Console.WriteLine($"Вы купили Меч! У вас осталось {Money} монет.");
                                    WeaponDef = SwordDef;
                                    WeaponDmg = SwordDmg;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            case ConsoleKey.H:
                                if (Money >= 30)
                                {
                                    Money = Money - 30;
                                    Console.WriteLine($"Вы купили Зелье исцеления! У вас осталось {Money} монет.");
                                    Potion++;
                                    IsTalk = false;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег.");
                                    IsTalk = false;
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("У меня всего 6 ячеек с предметами. Введите номер ячейки.");
                                    return;
                                }
                        }
                    }
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
                        Money = Money + 80;
                        Console.WriteLine($"У вас теперь {Money} монет.");
                    }
                    else if (EnemyDead == true)
                    {
                        Console.WriteLine("Ты убил его! Огромное тебе спасибо. Вот, возьми это в качестве платы.");
                        Console.WriteLine("Вы получили 150 золотых монет!");
                        Money = Money + 150;
                        Console.WriteLine($"У вас теперь {Money} монет.");
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
                        while ((PlayerHp > 0 && EnemyHp > 0) && IsFight)
                        {
                            Console.WriteLine("*Злобный рык*");
                            Console.WriteLine("W - Уйти, A - Атака оружием, D - Исцеление, S - Пропуск хода.");
                            ConsoleKeyInfo FightKey = Console.ReadKey(true);
                            switch (FightKey.Key)
                            {
                                case ConsoleKey.W:
                                    y--;
                                    IsFight = false;
                                    break;
                                case ConsoleKey.D:
                                    if (Potion > 0)
                                    {
                                        PlayerHp = PlayerHp + Heal - EnemyDmg;
                                        if (PlayerHp > 100)
                                        {
                                            PlayerHp = 100;
                                        }
                                        Console.WriteLine($"Вы выпили зелье! Но враг нанёс вам {EnemyDmg}. Ваше здоровье - {PlayerHp}.");
                                        Console.WriteLine($"У вас осталось {Potion} зелий.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас не осталось зелий!");
                                    }
                                    break;
                                case ConsoleKey.A:
                                    PlayerHp = PlayerHp - (EnemyDmg - WeaponDef - ArmorDef);
                                    EnemyHp = EnemyHp - PlayerDmg;
                                    Console.WriteLine($"Ваше здоровье - {PlayerHp}.");
                                    Console.WriteLine($"Здоровье врага - {EnemyHp}.");
                                    break;
                                case ConsoleKey.S:
                                    PlayerHp = PlayerHp - EnemyDmg;
                                    Console.WriteLine($"Ваше здоровье - {PlayerHp}.");
                                    Console.WriteLine($"Здоровье врага - {EnemyHp}.");
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (PlayerHp > 0 && EnemyHp < 0)
                        {
                            Console.WriteLine($"Ура, победа!");
                            IsFight = false;
                            EnemyDead = true;
                        }
                        else if (PlayerHp < 0 && EnemyHp > 0)
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
                _proto_zone.RenderPlayer(zone, y, x);

                //Заполнение поля / set
                Console.Write($"Здоровье: {PlayerHp} Урон:{WeaponDmg + 5}\nМонет: {Money} Зелий: {Potion}\n");

                _proto_zone.RenderZone(zone, y, x);

                //Управление
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
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
