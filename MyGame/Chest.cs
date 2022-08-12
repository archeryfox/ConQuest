using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Chest : Zone
    {
       
        public bool ChestOpen;
        public bool Book;

        public void Open(string[,] zone, int y, int x, int yb, int xb, bool ChestOpen, bool Book) 
        {
                if (this.ChestOpen == false)
                {
                    Console.WriteLine("Перед вами сундук. Вы открываете его.");
                    Console.WriteLine("Внутри не было ничего кроме старой пыльной книги под названием Утопия. Вы взяли ее с собой.");
                    this.ChestOpen = true;
                    this.Book = true;
                }
                else
                {
                    Console.WriteLine("Вы уже открывали этот сундук. Теперь он пуст.");
                }
        
        }
    }
                
}
