using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestNol_Test_DC
{
   public class Cell:Button
    {
        public string CellStatus { get; set; } // Статус клетки, empty, cross или null
        public string CellImage { get; set; }
        public int CellNumber { get; set; } // Порядковый номер клетки


        public Cell()
        {
            CellStatus = "empty";
            CellImage = "";
            CellNumber = 1;



            
        }
    }
}
