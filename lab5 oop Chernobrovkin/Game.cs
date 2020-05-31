using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestNol_Test_DC
{
   public class Game

    {
        public bool IsCrossWin = false;      //Выиграли крестики
        public bool IsNullWin = false;       //Выиграли нолики
        public bool IsDraw = false;          //Ничья
        public bool IsCrossTurnNow = false;  //Очередность хода(ходят ли сейчас крестики)
        public bool IsGameFinished = false;  //Игра закончилась

        public int UsedCellCount = 0;        // Кол-во использованных клеток поля в текущей игре
        public int CrossWinCount = 0;        // Кол-во побед крестиков
        public int NullWinCount = 0;         // Кол-во побед ноликов

        public Game()
        {

        }

        public void GameStatusCheck()        // Проверяет статус игры и выводит соответствующий message box
        {
            if (IsDraw == true)
            {
                Draw();
            }
            else if (IsCrossWin == true)
            {
                CrossWin();
                
            }
            else if (IsNullWin == true) 
            {
                NullWin();
            }

        }

        public void DrawCheck()  // Проверка на ничью
        {
            if ((IsCrossWin == false) && (IsNullWin == false) && (UsedCellCount == 9))
            {
                IsDraw = true;
            }
        }

       public void Draw() // Message box с ничьей
        {
            MessageBox.Show("Ничья!");
        }

        public void CrossWin() // Message box с победой крестиков
        {
            MessageBox.Show("Выиграли крестики!");
           // CrossWinCount++;
            
        }

        public void NullWin() // Message box с победой ноликов
        {
            MessageBox.Show("Выиграли нолики!");
            //NullWinCount++;
        }


        public void bool_Reset() // Cброс параметров для начала новой игры
        {
            IsCrossWin = false;
            IsNullWin = false;
            IsDraw = false;
            IsCrossTurnNow = false;
            IsGameFinished = false;
        }
    }
}
