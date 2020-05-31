using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestNol_Test_DC
{
    public partial class Form1 : Form
    {

        public Game game = new Game();
        public int field_size = 3;// кол-во клеток в длину и ширину
        public int distance = 65; //расстояние между клетками
        public int cell_count = 1; // счетчик номера клетки
        public int[] cell_arr = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for(int x = 3;(x-3)<field_size*distance;x+=distance)
            {
                for(int y = 3;(y-3)<field_size*distance;y+=distance)
                {
                    
                    Cell cell = new Cell();
                    cell.Location = new Point(x+50, y+50);
                    cell.Size = new Size(60, 60);
                    cell.CellNumber = cell_count;
                    cell_count++;
                    Controls.Add(cell);
                    cell.Click += new EventHandler(CellClick);
                    
                }
            }

            cell_count = 1;
        }

        void CellClick(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            if ((cell.CellStatus == "empty") && (game.IsGameFinished == false)) 
            {
                if(game.IsCrossTurnNow == false)
                {
                    SetNull(cell);
                }

                else
                {
                    SetCross(cell);
                }
            }
        }

       public void SetNull(Cell cell)
        {
            game.UsedCellCount++;
            //cell.CellNumber = game.UsedCellCount;
            cell_arr[cell.CellNumber] = 2;
           // Console.WriteLine(cell_arr[4]);

            cell.CellStatus = "null";
            game.IsCrossTurnNow = true;
            cell.Text = "O";
   
            NullWin_Check(cell);
            WinCounterCheck();

            game.DrawCheck();
            game.GameStatusCheck();
        }

        public void SetCross(Cell cell)
        {
            game.UsedCellCount++;
           // cell.CellNumber = game.UsedCellCount;
            cell_arr[cell.CellNumber] = 1;
           // Console.WriteLine(cell_arr[1]);

            cell.CellStatus = "cross";
            game.IsCrossTurnNow = false;
            cell.Text = "X";
    
            CrossWin_Check(cell);
            WinCounterCheck();

            game.DrawCheck();
            game.GameStatusCheck();
        }

        public void CrossWin_Check(Cell cell)
        {
           // if (cell_arr[1] == 1) game.IsCrossWin = true;
            if ((cell_arr[1] == cell_arr[2]) && (cell_arr[1] == cell_arr[3]) &&(cell_arr[1]==1))
                game.IsCrossWin = true;
            if ((cell_arr[4] == cell_arr[5]) && (cell_arr[4] == cell_arr[6]) && (cell_arr[4] == 1))
                game.IsCrossWin = true;
            if ((cell_arr[7] == cell_arr[8]) && (cell_arr[7] == cell_arr[9]) && (cell_arr[7] == 1))
                game.IsCrossWin = true;

            if ((cell_arr[1] == cell_arr[4]) && (cell_arr[1] == cell_arr[7]) && (cell_arr[1] == 1))
                game.IsCrossWin = true;
            if ((cell_arr[2] == cell_arr[5]) && (cell_arr[2] == cell_arr[8]) && (cell_arr[2] == 1))
                game.IsCrossWin = true;
            if ((cell_arr[3] == cell_arr[6]) && (cell_arr[3] == cell_arr[9]) && (cell_arr[3] == 1))
                game.IsCrossWin = true;

            if ((cell_arr[7] == cell_arr[5]) && (cell_arr[7] == cell_arr[3]) && (cell_arr[7] == 1))
                game.IsCrossWin = true;
            if ((cell_arr[1] == cell_arr[5]) && (cell_arr[1] == cell_arr[9]) && (cell_arr[1] == 1))
                game.IsCrossWin = true;


        }

        public void NullWin_Check(Cell cell)
        {
            if ((cell_arr[1] == cell_arr[2]) && (cell_arr[1] == cell_arr[3]) && (cell_arr[1] == 2))
                game.IsNullWin = true;
            if ((cell_arr[4] == cell_arr[5]) && (cell_arr[4] == cell_arr[6]) && (cell_arr[4] == 2))
                game.IsNullWin = true;
            if ((cell_arr[7] == cell_arr[8]) && (cell_arr[7] == cell_arr[9]) && (cell_arr[7] == 2))
                game.IsNullWin = true;

            if ((cell_arr[1] == cell_arr[4]) && (cell_arr[1] == cell_arr[7]) && (cell_arr[1] == 2))
                game.IsNullWin = true;
            if ((cell_arr[2] == cell_arr[5]) && (cell_arr[2] == cell_arr[8]) && (cell_arr[2] == 2))
                game.IsNullWin = true;
            if ((cell_arr[3] == cell_arr[6]) && (cell_arr[3] == cell_arr[9]) && (cell_arr[3] == 2))
                game.IsNullWin = true;

            if ((cell_arr[7] == cell_arr[5]) && (cell_arr[7] == cell_arr[3]) && (cell_arr[7] == 2))
                game.IsNullWin = true;
            if ((cell_arr[1] == cell_arr[5]) && (cell_arr[1] == cell_arr[9]) && (cell_arr[1] == 2))
                game.IsNullWin = true;
        }


        public void WinCounterCheck()
        {
            if (game.IsCrossWin == true)
            {
                game.IsGameFinished = true;
                game.CrossWinCount++;
                label_cross_wins.Text = game.CrossWinCount.ToString();   
            }

            if(game.IsNullWin == true)
            {
                game.IsGameFinished = true;
                game.NullWinCount++;
                label_null_wins.Text = game.NullWinCount.ToString();
                
            }
                
        }

        private void Label_cross_wins_Click(object sender, EventArgs e)
        {

        }

        private void Button_restart_Click(object sender, EventArgs e)
        {
           
            game.bool_Reset();
            foreach (Control c in Controls) 
                if (c is Cell)
                    ((Cell)c).Text = "";
            game.UsedCellCount = 0;

            foreach (Control c in Controls)
                if (c is Cell)
                    ((Cell)c).CellStatus = "empty";

            Array.Clear(cell_arr, 0, cell_arr.Length);
           
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            game.bool_Reset();
            foreach (Control c in Controls)
                if (c is Cell)
                    ((Cell)c).Text = "";
            game.UsedCellCount = 0;

            foreach (Control c in Controls)
                if (c is Cell)
                    ((Cell)c).CellStatus = "empty";

            Array.Clear(cell_arr, 0, cell_arr.Length);
            game.CrossWinCount = 0;
            game.NullWinCount = 0;
            label_cross_wins.Text = 0.ToString();
            label_null_wins.Text = 0.ToString();
        }

        //private void toolStripMenuItem_param_Click(object sender, EventArgs e)
        //{
        //    Form2 Form_param = new Form2();
        //    Form_param.Show();
        //}
    }

}
