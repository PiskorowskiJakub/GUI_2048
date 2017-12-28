using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_2048
{
    class Board : User
    {
        public int randNumber = 0;
        public int rand1 = 2;      // pierwsza losowa liczba
        public int rand2 = 4;      // druga losowa liczba
        public static int coordinateXnumber1, coordinateYnumber1;

        public void UpdateBoard()
        {
            cell_00.Text = board[0, 0].ToString();
            cell_10.Text = board[1, 0].ToString();
            cell_20.Text = board[2, 0].ToString();
            cell_30.Text = board[3, 0].ToString();

            cell_01.Text = board[0, 1].ToString();
            cell_11.Text = board[1, 1].ToString();
            cell_21.Text = board[2, 1].ToString();
            cell_31.Text = board[3, 1].ToString();

            cell_02.Text = board[0, 2].ToString();
            cell_12.Text = board[1, 2].ToString();
            cell_22.Text = board[2, 2].ToString();
            cell_32.Text = board[3, 2].ToString();

            cell_03.Text = board[0, 3].ToString();
            cell_13.Text = board[1, 3].ToString();
            cell_23.Text = board[2, 3].ToString();
            cell_33.Text = board[3, 3].ToString();
        }

        public int RandValue()
        {
            Random rand = new Random();
            int a = rand.Next(1, 100);
            if (a < 85)
            {
                randNumber = rand1;
                return randNumber;
            }
            else if (a >= 85)
            {
                randNumber = rand2;
                return randNumber;
            }
            else
                return randNumber;
        }

        public void RandCoordinates(int _sizeBoard)
        {
            do
            {
                Random rand0 = new Random();
                coordinateXnumber1 = rand0.Next(0, _sizeBoard);
                coordinateYnumber1 = rand0.Next(0, _sizeBoard);

            } while (board[coordinateXnumber1, coordinateYnumber1] != emptyy);
            board[coordinateXnumber1, coordinateYnumber1] = randNumber;

        }
    }
}
