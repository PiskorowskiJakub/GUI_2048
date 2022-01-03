//  Created by Jakub Piskorowski on 20/05/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_2048
{

    class Board 
    {
       
        public int randNumber = 0;
        public int rand1 = 2;      // pierwsza losowa liczba
        public int rand2 = 4;      // druga losowa liczba
        public static int coordinateXnumber1, coordinateYnumber1;
        public static string[,] output = new string[9, 9];

        User User = new User();

        public void ConvertBytes(int _sizeboard)
        {
            // Dictionary zamiast switch
            for (int i = 0; i <= _sizeboard; i += 1)
            {
                for (int j = 0; j <= _sizeboard; j += 1)
                {
                    switch(User.board[i,j])
                    {
                        case 0: output[i,j] = " "; break;
                        case 2: output[i, j] = "2 kb"; break;
                        case 4: output[i, j] = "4 kb"; break;
                        case 8: output[i, j] = "8 kb"; break;
                        case 16: output[i, j] = "16 kb"; break;
                        case 32: output[i, j] = "32 kb"; break;
                        case 64: output[i, j] = "64 kb"; break;
                        case 128: output[i, j] = "128 kb"; break;
                        case 256: output[i, j] = "256 kb"; break;
                        case 512: output[i, j] = "512 kb"; break;
                        case 1024: output[i, j] = "1 MB"; break;
                        case 2048: output[i, j] = "2 MB"; break;
                        case 4096: output[i, j] = "4 MB"; break;
                        case 8192: output[i, j] = "8 MB"; break;
                        case 16384: output[i, j] = "16 MB"; break;
                        case 32768: output[i, j] = "32 MB"; break;
                        case 65536: output[i, j] = "64 MB"; break;
                        case 131072: output[i, j] = "128 MB"; break;
                        case 262144: output[i, j] = "256 MB"; break;
                        case 524288: output[i, j] = "512 MB"; break;
                        default: output[i, j] = "-"; break;
                    }
                }
            }
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
            ++_sizeBoard;
            do
            {
                Random rand0 = new Random();
                coordinateXnumber1 = rand0.Next(0, _sizeBoard);
                coordinateYnumber1 = rand0.Next(0, _sizeBoard);

            } while (User.board[coordinateXnumber1, coordinateYnumber1] != User.emptyy);
            User.board[coordinateXnumber1, coordinateYnumber1] = randNumber;

        }
    }
}
