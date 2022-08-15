using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_7_game
{
    internal class Program 
    {
        
        static void Main(string[] args)
        {
            //Рандомайзер
            Random random = new Random();
            //Размер поля
            string[,] zone = new string[9, 16];
            //Комнаты
            void Room0(int i, int j)
            {
                switch (i, j)
                {
                    case (4, 2):
                        zone[i, j] = " w";
                        break;
                    case (0, >= 0 and <= 4):
                    case (1, >= 0 and <= 2):
                    case (2, >= 0 and <= 1):
                    case ( >= 3 and <= 6, 0):
                    case (2, 3):
                    case (4, 4):
                    case (7, 1):
                    case (3, 10):
                    case (2, 11):
                    case (7, 12):
                    case (7, 8):
                        zone[i, j] = " Y";
                        break;
                    case ( >= 1 and <= 3, 13):
                    case (8, 13):
                        zone[i, j] = " |";
                        break;
                    case (0, >= 4 and <= 13):
                    case (3, >= 14 and <= 15):
                    case (7, >= 14 and <= 15):
                        zone[i, j] = "__";
                        break;
                    default:
                        break;
                }
                Console.Write($" {zone[i, j]}");
            }
            void Room1(int i, int j)
            {

                switch (i, j)
                {
                    case (5, 12):
                        zone[i, j] = "* ";
                        break;
                    case (4, 0):
                    case (5, 0):
                    case (6, 0):
                        zone[i, j] = " #";
                        break;
                    case (0, 10):
                    case ( >= 2 and <= 8, 15):
                        zone[i, j] = "| ";
                        break;
                    case (2, 1):
                    case (8, 1):

                    case (0, 6):
                        zone[i, j] = " |";
                        break;
                    case (8, >= 2 and <= 14):
                    case (1, >= 2 and <= 6):
                    case (1, >= 10 and <= 14):
                    case (7, 0):
                    case (7, 1):
                    case (3, 0):
                    case (3, 1):
                        zone[i, j] = "__";
                        break;
                    default:
                        break;
                }
                Console.Write($" {zone[i, j]}");
            }
            void Room2(int i, int j)
            {
                switch (i, j)
                {
                    case (4, 8):
                        zone[i, j] = " ?";
                        break;
                    case ( >= 1 and <= 7, 15):
                    case (8, 10):
                        zone[i, j] = "| ";
                        break;
                    case (1, 1):
                    case (7, 1):
                    case (8, 6):
                        zone[i, j] = " |";
                        break;
                    case (0, >= 2 and <= 14):
                    case (7, >= 2 and <= 6):
                    case (7, >= 10 and <= 14):
                    case (2, >= 0 and <= 1):
                    case (6, >= 0 and <= 1):
                        zone[i, j] = "__";
                        break;
                    default:
                        break;
                }
                Console.Write($" {zone[i, j]}");
            }
            void Room3(int i, int j)
            {
                switch (i, j)
                {
                    case (>=1 and <=7, 0):
                        zone[i, j] = " |";
                        break;
                    case ( >= 3 and <= 5, 15):
                        zone[i, j] = " #";
                        break;
                    case (1, 14):
                    case (8, 14):
                        zone[i, j] = "| ";
                        break;
                    case (2, >= 14 and <= 15):
                    case (6, >= 14 and <= 15):
                    case (0, >= 1 and <= 13):
                    case (8, >= 1 and <= 13):
                        zone[i, j] = "__";
                        break;
                    case (4,3):
                        zone[i, j] = "[]";
                        break;
                    default:
                        break;
                }
                Console.Write($" {zone[i, j]}");
            }
            void Room4(int i, int j)
            {
                switch (i, j)
                {
                    default:
                        break;
                }
                Console.Write($" {zone[i, j]}");
            }
            //Настройки врага
            int ye = 4, xe = 6;
            int hpe = 10;
            int mpe = 0;
            int pwe = 2;
            int runtime = 0;
            bool dir = false;
            void Enemy(int i, int j)
            {
                if (i==ye && j==xe) {
                    zone[i, j] = " x";
                }
            }
            //Игрок
            int hp = 20;
            int mp = 10;
            int pw = 2;
            int money = 12;
            bool hat = false;
            //Спавн игрока
            //int y = 5, x = 7;
            int y = 4, x = 13;
            //Буфер
            int yb = y, xb = x;
            int ybe = ye, xbe = xe;
            //Номер локации
            int loc = 3;
            //Состояние диалога
            bool ms = false;
            //Готовность к диалогу
            bool gm = false;
            //Игрок
            bool sw = true;
            //Наличие квеста
            bool qst = false;
            //Комментарий торговца
            bool tk = false;
            //Дверь в подземелье
            bool dd = false;
            //Люк
            bool trapdoor = false;
            //Место диалога
            int locms = 0;

            while (true)
            {
                //Переход между локациями
                switch (y, x, loc)
                {
                    case ( >= 4 and <= 6, 16, 0):
                        loc = 1;
                        x -= 15;
                        break;
                    case (-1, >= 7 and <= 9, 1):
                        loc = 2;
                        y += 8;
                        break;
                    case (9, >= 7 and <= 9, 2):
                        loc = 1;
                        y -= 8;
                        break;
                    case ( >= 3 and <= 5, -1, 2):
                        loc = 3;
                        x += 15;
                        break;
                }
                switch (trapdoor, loc)
                {
                    case (true, 3):
                        loc = 4;
                        yb = 4;
                        xb = 3;
                        y = 4;
                        x = 3;
                        break;
                }

                //Проверка на препятствия
                if (dir = true && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                {
                    ye = ybe;
                    xe = xbe;
                    ye++;
                    if (dir = true && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                    {
                        ye = ybe;
                        xe = xbe;
                        ye--;
                    }
                }
                if (dir = false && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                {
                    ye = ybe;
                    xe = xbe;
                    xe++;
                    if (dir = false && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                    {
                        ye = ybe;
                        xe = xbe;
                        xe--;
                    }
                }
                if (zone[y, x] == " #" || zone[y, x] == " |" || zone[y, x] == "__" || zone[y, x] == "| " || zone[y, x] == "* " || zone[y, x] == " ?" || zone[y, x] == " Y" || zone[y, x] == " w" || zone[y, x] == "[]")
                {
                    y = yb;
                    x = xb;
                }
                
                //Бой
                if (y==ye && x==xe && runtime==0 && loc==3) 
                {
                    int menu = 1;
                    int menu2 = 0;
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine($"\t\tFight\n\tYou\t\t  Enemy");
                        Console.WriteLine($"       HP {hp}\t\t  HP {hpe}");
                        Console.WriteLine($"       MP {mp}\t\t  MP {mpe}");
                        Console.WriteLine($"       PW {pw}\t\t  PW {pwe}\n");
                        switch (menu,menu2)
                        {
                            case (1,0):
                                Console.WriteLine("   <Атака>\tИнвентарь\tСбежать");
                                break;
                            case (2,0):
                                Console.WriteLine("   Атака\t<Инвентарь>\tСбежать");
                                break;
                            case (3,0):
                                Console.WriteLine("   Атака\tИнвентарь\t<Сбежать>");
                                break;
                            case (1,1):
                                Console.Write("   <Назад>\t");
                                if (sw==true)
                                {
                                    Console.Write("Меч\t");
                                }
                                Console.Write("Игнорировать");
                                break;
                            case (2,1):
                                Console.Write("   Назад\t");
                                if (sw == true)
                                {
                                    Console.Write("<Меч>\t");
                                }
                                Console.Write("Игнорировать");
                                break;
                            case (3, 1):
                                Console.Write("   Назад\t");
                                if (sw == true)
                                {
                                    Console.Write("Меч\t");
                                }
                                Console.Write("<Игнорировать>");
                                break;
                            case (1, 2):
                                Console.Write("   <Назад>\t");
                                if (hat == true)
                                {
                                    Console.Write("Шляпа\t");
                                }
                                break;
                            case (2, 2):
                                Console.Write("   Назад\t");
                                if (hat == true)
                                {
                                    Console.Write("<Шляпа>\t");
                                }
                                break;
                        }
                        Console.WriteLine($"");
                        ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                        switch (consoleKey.Key)
                        {
                            case ConsoleKey.D:
                                menu++;
                                break;
                            case ConsoleKey.A:
                                menu--;
                                break;
                            case ConsoleKey.F:
                                switch(menu,menu2)
                                {
                                    case (1,0):
                                        menu2 = 1;
                                        break;
                                    case (2, 0):
                                        menu = 1;
                                        menu2 = 2;
                                        break;
                                    case (3, 0):
                                        if (random.Next(3) == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n\n\t\tВы сбежали\n\n\n\n");
                                            runtime = 3;
                                            Console.ReadKey(true);
                                        } else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n\n\t\tВам не удалось сбежать\n\tНажмите любую клавишу для продолжения\n\n\n");
                                            hp -= pwe;
                                            Console.ReadKey(true);
                                        }
                                        break;
                                    case (1, 1):
                                        menu2 = 0;
                                        break;
                                    case (2, 1):
                                        menu = 1;
                                        menu2 = 0;
                                        hp -= pwe;
                                        hpe -= pw;
                                        break;
                                    case (3, 1):
                                        menu = 1;
                                        menu2 = 0;
                                        hp -= pwe;
                                        break;
                                    case (1, 2):
                                        menu = 2;
                                        menu2 = 0;
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        if (menu == 4 && menu2 == 0)
                        {
                            menu--;
                        }
                        if (menu == 4 && menu2 == 1)
                        {
                            menu--;
                        }
                        if (menu == 3 && menu2 == 2)
                        {
                            menu--;
                        }
                        if (menu == 0)
                        {
                            menu++;
                        }
                        if (runtime > 0 || hp <= 0 || hpe <=0)
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    if (hp <= 0)
                    {
                        Console.WriteLine("\n\n\n\n\n\t\tМонстр вас вырубил\n\n\n\n");
                        Console.ReadKey(true);
                    }
                    if (hpe <= 0)
                    {
                        int reward = (10 + random.Next(5));
                        money += reward;
                        Console.WriteLine($"\n\n\n\n\n\t\tВы одолели монстра!\n\t\tЗолото +{reward}\n\n\n");
                        Console.ReadKey(true);
                    }
                    
                    Console.Clear();
                }

                //Перезапись буфера
                yb = y;
                xb = x;
                gm = false;
                ybe = ye;
                xbe = xe;

                //Создание поля / get
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

                //Заполнение поля / set
                for (int i = 0; i < zone.GetUpperBound(0) + 1 /* y */; i++)
                {
                    for (int j = 0; j < zone.GetUpperBound(1) + 1/* x */; j++)
                    {
                        switch (dd, loc, i, j)
                        {
                            case (false, 2, >= 3 and <= 5, 0):
                                zone[i, j] = " #";
                                break;
                        }
                        if (hpe > 0)
                        {
                            switch (loc)
                            {
                                case 3:
                                    Enemy(i, j);
                                    break;
                            }
                        }
                        switch (loc)
                        {
                            case 0:
                                Room0(i, j);
                                break;
                            case 1:
                                Room1(i, j);
                                break;
                            case 2:
                                Room2(i, j);
                                break;
                            case 3:
                                Room3(i, j);
                                break;
                            case 4:
                                Room4(i, j);
                                break;
                        }
                        
                    }
                    Console.WriteLine("");
                }

                //Зона действия
                switch (y, x, ms, loc)
                {
                    case ( >= 3 and <= 5, 2, false, 0):
                    case (4, >= 1 and <= 3, false, 0):
                        locms = 0;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case (8, >= 2 and <= 12, false, 0):
                        Console.WriteLine("Я не могу вернуться в деревню без потерянного меча. \nМне уже заплатили.");
                        break;
                    case ( >= 4 and <= 6, 12, false, 1):
                    case (5, >= 11 and <= 13, false, 1):
                        locms = 1;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case ( >= 4 and <= 6, 1, false, 1):
                        locms = 2;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case ( >= 3 and <= 5, 8, false, 2):
                    case (4, >= 7 and <= 9, false, 2):
                        locms = 3;
                        if (dd == true)
                        {
                            Console.WriteLine("Я должен одолеть лича и помочь этому парню выбраться.");
                        }
                        else
                        {
                            Console.WriteLine("Человек закутанный в одеяло с потрёпанной шляпой на голове.\nСмахивает на торговца.");
                        }
                        Console.WriteLine("Поговорить: F");
                        gm = true;
                        break;
                    case (4, >= 2 and <= 4, false, 3):
                    case ( >= 3 and <= 5, 3, false, 3):
                        Console.WriteLine("Открытый ржавый люк\nСпуститься: F");
                        trapdoor = true;
                        break;
                }

                //Текст бар
                switch (ms, sw, qst, tk, dd, locms)
                {
                    case (true, false, false, false, false, 0):
                        Console.WriteLine("Костёр согревает даже в самую холодную зиму...");
                        ms = false;
                        break;
                    case (true, false, true or false, true or false, true or false, 1):
                        Console.WriteLine("Среди листьев вы нашли меч!");
                        sw = true;
                        ms = false;
                        break;
                    case (true, true, true or false, true or false, true or false, 1):
                        Console.WriteLine("Тут больше ничего нет.");
                        ms = false;
                        break;
                    case (true, true or false, false, true or false, true or false, 2):
                        Console.WriteLine("О нет! Дверь закрылась снаружи. \nВряд ли её можно открыть отсюда..");
                        ms = false;
                        break;
                    case (true, true or false, true, true or false, true or false, 2):
                        Console.WriteLine("Я не смогу открыть эту дверь. \nНужно идти дальше.");
                        ms = false;
                        break;
                    case (true, true or false, false, false, false, 3):
                        Console.WriteLine("Mae govannen! Рад увидеть человека, хоть и жаль что в таком месте...\nТы как и я попал в ловушку лича. Живущего в конце этой пещеры.");
                        ms = false;
                        qst = true;
                        tk = true;
                        break;
                    case (true, true or false, true, true, false, 3):
                        Console.WriteLine("Я слишком слаб что бы сразить его.. \nНо если у тебя есть меч, я могу открыть проход для тебя.");
                        ms = false;
                        tk = false;
                        break;
                    case (true, true, true, false, false, 3):
                        Console.WriteLine("Вижу ты нашёл меч, я открою для тебя дверь..\nВ качестве благодарности пожалуйста возьми мою шляпу. Мой отец говорил она приносит удачу..");
                        ms = false;
                        dd = true;
                        hat = true;
                        break;
                    case (true, false, true, false, false, 3):
                        Console.WriteLine("Ты хочешь остаться со мной? Я был бы рад умереть не в одиночестве..");
                        ms = false;
                        break;
                    case (true, true, true, false, true, 3):
                        Console.WriteLine("Мне придётся закрыть за тобой дверь что-бы монстры не добрались сюда. \nПожалуйста береги себя..");
                        ms = false;
                        break;
                }
                switch (ms, dd, locms)
                {
                    case (true, true, 4):
                        break;
                    default:
                        break;
                }

                //Характеристики
                Console.WriteLine($"\nHP = {hp}/20\nMP = {mp}/10\nPW = {pw}");
                Console.WriteLine("-----------");
                if (sw == true)
                {
                    Console.WriteLine("Меч +3");
                    pw = 5;
                }
                if (hat == true)
                {
                    Console.WriteLine("Шляпа");
                }
                if (sw == true)
                {
                    Console.WriteLine("-----------");
                }
                Console.WriteLine($"Золото - {money}м");

                //Временные данные
                Console.WriteLine("\n" + y);
                Console.WriteLine(x);

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
                    case ConsoleKey.F:
                        if (gm == true)
                        {
                            ms = true;
                        }
                        break;
                    default:
                        break;
                }

                //Движение врага
                if (runtime == 0 && hpe > 0 && loc==3)
                {
                    if ((ye - y) == 1 || (ye - y) == -1 || (ye - y) == 0 || (xe - x) == 1 || (xe - x) == -1 || (xe - x) == 1)
                    {
                        if (ye > y)
                        {
                            ye--;
                        }
                        else if (ye < y)
                        {
                            ye++;
                        }
                        dir = true;
                        if (xe > x)
                        {
                            xe--;
                        }
                        else if (xe < x)
                        {
                            xe++;
                        }
                        dir = false;
                    } 
                    else {
                        if (ye > yb)
                        {
                            ye--;
                        }
                        else if (ye < yb)
                        {
                            ye++;
                        }
                        dir = true;
                        if (xe > xb)
                        {
                            xe--;
                        }
                        else if (xe < xb)
                        {
                            xe++;
                        }
                        dir = false;
                    }
                }
                if (runtime > 0)
                {
                    runtime--;
                }

                Console.Clear();
            }
        }
    }
}