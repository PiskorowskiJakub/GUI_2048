using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_2048
{
    class Key : User
    {
        public int board_clear;
        public int falsee = 0;

        public int check_y = 0;                                    // sprawdzenie po zmiennej y
       // public int check_y_next, check_y_next2, check_y_next4;     // sprawdzenie kolejnej wartosci zmiennej y

        public int check_x = 0;                                    // sprawdzenie po zmiennej x
        /*
        public int check_x_next, check_x_next2, check_x_next4;     // sprawdzenie kolejnej wartosci zmiennej x

        public int check_x_priev, check_x_priev2, check_x_priev4;      // sprawdzenie poprzedniej wartosci zmiennej x
        public int check_y_priev, check_y_priev2, check_y_priev4;      // sprawdzenie poprzedniej wartosci zmiennej y
        */
        public int check_move = 0;


        public void Checkclear()
        {
            board_clear = 0;            // Sprawdzenie czy sa puste pola
            for (int i = 1; i < 9; i += 2)
            {
                for (int j = 1; j < 9; j += 2)
                {
                    if (board[i, j] == emptyy)
                    {
                        board_clear += 1;
                    }
                }
            }
        }



        public void CheckKey(int _sizeBoard, KeyEventArgs _key1)
        {


            if (_key1.Key == System.Windows.Input.Key.W || _key1.Key == System.Windows.Input.Key.Up)
            {
                for (check_y = 0; check_y <= _sizeBoard; check_y += 1)
                {
                    for (check_x = 0; check_x <= _sizeBoard; check_x += 1)
                    {
                        
                        // sprawdzamy wiersze od ostatniego do pierwszego
                        for (int max = _sizeBoard; max <= check_y; max--)
                        {
                            // jezeli 1 i ostatni wiersz jest taki sam 
                            if (board[check_y, check_x] == board[max, check_x])
                            {
                                // sprawdzamy elementy tablicy miedzy 1 a ostatnim wierszem
                                for (int i = check_y; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (board[i, check_x] != emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // jezeli srodkowe wiersze sa puste
                                if (falsee == 0)
                                {
                                    // dodanie komorki wiersza 1 i ostatniego
                                    board[check_y, check_x] += board[max, check_x];
                                    // ostatnia komorke wiersza wypelniamy zerami
                                    board[max, check_x] = emptyy;
                                }
                            }
                        }
                            

                            
                        


                    }
                }
            }


                /*
                _sizeBoard += 1;

                check_move = 0;
                if (_key1.Key == System.Windows.Input.Key.W || _key1.Key == System.Windows.Input.Key.Up)
                {
                    for (check_x = 0; check_x < _sizeBoard; check_x += 1)
                    {
                        for (check_y = 0; check_y < _sizeBoard; check_y += 1)
                        {
                            check_y_next = check_y + 1;
                            check_y_next2 = check_y_next + 1;
                            check_y_next4 = check_y_next + 2;

                            if (board[check_y, check_x] == board[check_y_next, check_x] && board[check_y_next, check_x] != emptyy)  // dodanie liczb z wiersza (1 i 3)
                            {
                                board[check_y, check_x] += board[check_y_next, check_x];
                                board[check_y_next, check_x] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == board[check_y_next2, check_x] && board[check_y_next, check_x] == emptyy && board[check_y_next2, check_x] != emptyy)  // dodanie wiersza (1 i 5) jezli 3 jest pusty
                            {
                                board[check_y, check_x] += board[check_y_next2, check_x];
                                board[check_y_next2, check_x] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == board[check_y_next4, check_x] && board[check_y_next, check_x] == emptyy && board[check_y_next2, check_x] == emptyy && board[check_y_next4, check_x] != emptyy)   // dodanie wiersza (1 i 7) jezli 3 i 5 jest pusty
                            {
                                board[check_y, check_x] += board[check_y_next4, check_x];
                                board[check_y_next4, check_x] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y_next, check_x] != emptyy)    // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 3
                            {
                                board[check_y, check_x] = board[check_y_next, check_x];
                                board[check_y_next, check_x] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y_next2, check_x] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 5
                            {
                                board[check_y, check_x] = board[check_y_next2, check_x];
                                board[check_y_next2, check_x] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y_next4, check_x] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 7
                            {
                                board[check_y, check_x] = board[check_y_next4, check_x];
                                board[check_y_next4, check_x] = emptyy;
                                check_move += 1;
                            }
                        }
                    }

                }


                if (_key1.Key == System.Windows.Input.Key.A || _key1.Key == System.Windows.Input.Key.Left)
                {
                    for (check_x = 0; check_x < _sizeBoard; check_x += 1)
                    {
                        for (check_y = 0; check_y < _sizeBoard; check_y += 1)
                        {
                            check_x_next = check_x + 1;
                            check_x_next2 = check_x_next + 1;
                            check_x_next4 = check_x_next + 2;

                            if (board[check_y, check_x] == board[check_y, check_x_next] && board[check_y, check_x_next] != emptyy)  // dodanie liczb z wiersza (1 i 3)
                            {
                                board[check_y, check_x] += board[check_y, check_x_next];
                                board[check_y, check_x_next] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == board[check_y, check_x_next2] && board[check_y, check_x_next2] == emptyy && board[check_y, check_x_next2] != emptyy) // dodanie wiersza (1 i 5) jezli 3 jest pusty
                            {
                                board[check_y, check_x] += board[check_y, check_x_next2];
                                board[check_y, check_x_next2] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == board[check_y, check_x_next4] && board[check_y, check_x_next] == emptyy && board[check_y, check_x_next2] == emptyy && board[check_y, check_x_next4] != emptyy)   // dodanie wiersza (1 i 7) jezli 3 i 5 jest pusty
                            {
                                board[check_y, check_x] += board[check_y, check_x_next4];
                                board[check_y, check_x_next4] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y, check_x_next] != emptyy)    // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 3
                            {
                                board[check_y, check_x] = board[check_y, check_x_next];
                                board[check_y, check_x_next] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y, check_x_next2] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 5
                            {
                                board[check_y, check_x] = board[check_y, check_x_next2];
                                board[check_y, check_x_next2] = emptyy;
                                check_move += 1;
                            }
                            if (board[check_y, check_x] == emptyy && board[check_y, check_x_next4] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 7
                            {
                                board[check_y, check_x] = board[check_y, check_x_next4];
                                board[check_y, check_x_next4] = emptyy;
                                check_move += 1;
                            }
                        }
                    }
                }


                _sizeBoard -= 1;

                if (_key1.Key == System.Windows.Input.Key.D || _key1.Key == System.Windows.Input.Key.Right)
                {
                    for (check_x = _sizeBoard; check_x >= 0; check_x -= 1)
                    {
                        for (check_y = _sizeBoard; check_y >= 0; check_y -= 1)
                        {
                            check_x_priev = check_x - 1;
                            check_x_priev2 = check_x_priev - 1;
                            check_x_priev4 = check_x_priev - 2;

                            if (check_x_priev4 >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y, check_x_priev4] && board[check_y, check_x_priev] == emptyy && board[check_y, check_x_priev2] == emptyy && board[check_y, check_x_priev4] != emptyy)   // dodanie wiersza (1 i 7) jezli 3 i 5 jest pusty
                                {
                                    board[check_y, check_x] += board[check_y, check_x_priev4];
                                    board[check_y, check_x_priev4] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_x_priev4 >= 0)
                            {
                                if (board[check_y, check_x] == emptyy && board[check_y, check_x_priev4] != emptyy)  // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 7
                                {
                                    board[check_y, check_x] = board[check_y, check_x_priev4];
                                    board[check_y, check_x_priev4] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_x_priev2 >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y, check_x_priev2] && board[check_y, check_x_priev2] == emptyy && board[check_y, check_x_priev2] != emptyy)  // dodanie wiersza (1 i 5) jezli 3 jest pusty
                                {
                                    board[check_y, check_x] += board[check_y, check_x_priev2];
                                    board[check_y, check_x_priev2] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_x_priev2 >= 0)
                            {
                                if (board[check_y, check_x] == emptyy && board[check_y, check_x_priev2] != emptyy)  // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 5
                                {
                                    board[check_y, check_x] = board[check_y, check_x_priev2];
                                    board[check_y, check_x_priev2] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_x_priev >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y, check_x_priev] && board[check_y, check_x_priev] != emptyy)    // dodanie liczb z wiersza (1 i 3)
                                {
                                    board[check_y, check_x] += board[check_y, check_x_priev];
                                    board[check_y, check_x_priev] = emptyy;
                                    check_move += 1;
                                    //                      test1.Text = check_y.ToString();
                                }
                            }
                            if (check_x_priev >= 0)
                            {
                                if (board[check_y, check_x] == emptyy && board[check_y, check_x_priev] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 3
                                {
                                    board[check_y, check_x] = board[check_y, check_x_priev];
                                    board[check_y, check_x_priev] = emptyy;
                                    check_move += 1;
                                }
                            }
                        }
                    }
                }



                if (_key1.Key == System.Windows.Input.Key.S || _key1.Key == System.Windows.Input.Key.Down)
                {
                    for (check_x = _sizeBoard; check_x >= 0; check_x -= 1)
                    {
                        for (check_y = _sizeBoard; check_y >= 0; check_y -= 1)
                        {
                            check_y_priev = check_y - 1;
                            check_y_priev2 = check_y_priev - 1;
                            check_y_priev4 = check_y_priev - 2;

                            if (check_y_priev >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y_priev, check_x] && board[check_y_priev, check_x] != emptyy)    // dodanie liczb z wiersza (1 i 3)
                                {
                                    board[check_y, check_x] += board[check_y_priev, check_x];
                                    board[check_y_priev, check_x] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_y_priev2 >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y_priev2, check_x] && board[check_y_priev, check_x] == emptyy && board[check_y_priev2, check_x] != emptyy)   // dodanie wiersza (1 i 5) jezli 3 jest pusty
                                {
                                    board[check_y, check_x] += board[check_y_priev2, check_x];
                                    board[check_y_priev2, check_x] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_y_priev4 >= 0)
                            {
                                if (board[check_y, check_x] == board[check_y_priev4, check_x] && board[check_y_priev, check_x] == emptyy && board[check_y_priev2, check_x] == emptyy && board[check_y_priev4, check_x] != emptyy)   // dodanie wiersza (1 i 7) jezli 3 i 5 jest pusty
                                {
                                    board[check_y, check_x] += board[check_y_priev4, check_x];
                                    board[check_y_priev4, check_x] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_y_priev >= 0)
                            {
                                if (board[check_y, check_x] == emptyy && board[check_y_priev, check_x] != emptyy)   // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 3
                                {
                                    board[check_y, check_x] = board[check_y_priev, check_x];
                                    board[check_y_priev, check_x] = emptyy;
                                    check_move += 1;
                                }
                            }
                            if (check_y_priev2 >= 0)
                            {
                                if (board[check_y, check_x] == emptyy && board[check_y_priev2, check_x] != emptyy)  // jesli wiersz 1 jest pusty wstaw zawartosc wiersza 5
                                {
                                    board[check_y, check_x] = board[check_y_priev2, check_x];
                                    board[check_y_priev2, check_x] = emptyy;
                                    check_move += 1;
                                }
                            }

                        }
                    }
                }
                */


            }


    }
}
