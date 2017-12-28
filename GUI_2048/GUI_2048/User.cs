using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_2048
{
    class User : Plansza4x4
    {
        public int emptyy; // pole puste
        //public string name;
        public int points;
        public int loadBoard;
        public int sumPoint;

        public static int[,] board = new int[9, 9];

        
        public void CreateBoard(int _sizeBoard)
        {
            emptyy = 0;
            // nadajemy wartoœæ 0000 (pole puste) tablicy "pole"

            for (int i = 0; i <= _sizeBoard; i++)
            {
                for (int j = 0; j <= _sizeBoard; j++)
                {
                    board[i, j] = emptyy;
                }
            }
        }
/*
        public void CheckUser()
        {
            name = "Jacob";
            points = 0;
        }
        */
    }
}
