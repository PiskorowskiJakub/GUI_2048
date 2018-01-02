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
        public static string[,] output = new string[9, 9];

        public string ConvertBytes()
        {
            // Dictionary zamiast switch
            for (int i = 1; i < 9; i += 2)
            {
                for (int j = 1; j < 9; j += 2)
                {
                    switch(board[i,j])
                    {
                        case 0: return output[i,j] = " ";
                        case 2: return output[i, j] = "2 kb";
                        case 4: return output[i, j] = "4 kb";
                        case 8: return output[i, j] = "8 kb";
                        case 16: return output[i, j] = "16 kb";
                        case 32: return output[i, j] = "32 kb";
                        case 64: return output[i, j] = "64 kb";
                        case 128: return output[i, j] = "128 kb";
                        case 256: return output[i, j] = "256 kb";
                        case 512: return output[i, j] = "512 kb";
                        case 1024: return output[i, j] = "1 MB";
                        case 2048: return output[i, j] = "2 MB";
                        case 4096: return output[i, j] = "4 MB";
                        case 8192: return output[i, j] = "8 MB";
                        case 16384: return output[i, j] = "16 MB";
                        case 32768: return output[i, j] = "32 MB";
                        case 65536: return output[i, j] = "65 MB";
                        default: return output[i, j] = " ";
                    }
                }
            }
            return output[3, 3] = " ";
        }

        public void UpdateBoard()
        {
            cell_00.Text = output[0, 0];
            cell_10.Text = output[1, 0];
            cell_20.Text = output[2, 0];
            cell_30.Text = output[3, 0];

            cell_01.Text = output[0, 1];
            cell_11.Text = output[1, 1];
            cell_21.Text = output[2, 1];
            cell_31.Text = output[3, 1];

            cell_02.Text = output[0, 2];
            cell_12.Text = output[1, 2];
            cell_22.Text = output[2, 2];
            cell_32.Text = output[3, 2];

            cell_03.Text = output[0, 3];
            cell_13.Text = output[1, 3];
            cell_23.Text = output[2, 3];
            cell_33.Text = output[3, 3];
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
