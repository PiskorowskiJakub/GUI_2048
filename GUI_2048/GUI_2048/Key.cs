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
    class Key
    {

        public bool check_move = false;
        public bool board_clear = false;
        public int falsee = 0;

        public int check_y = 0;                  // sprawdzenie po zmiennej y
       // public int check_y_next, check_y_next2, check_y_next4;     // sprawdzenie kolejnej wartosci zmiennej y

        public int check_x = 0;                  // sprawdzenie po zmiennej x
        public int check_next_y = 0;            // zmenna pomocnicza
        public int check_next_x = 0;            // zmenna pomocnicza
        /*
        public int check_x_next, check_x_next2, check_x_next4;     // sprawdzenie kolejnej wartosci zmiennej x

        public int check_x_priev, check_x_priev2, check_x_priev4;      // sprawdzenie poprzedniej wartosci zmiennej x
        public int check_y_priev, check_y_priev2, check_y_priev4;      // sprawdzenie poprzedniej wartosci zmiennej y
        */
        //  public int check_move = 0;

        User User = new User();

        public bool Checkclear(int _sizeBoard)
        {
            board_clear = false;

            // Sprawdzenie czy sa puste pola
            for (int i = 0; i <= _sizeBoard; i++)
            {
                for (int j = 0; j <= _sizeBoard; j++)
                {
                    if (User.board[i, j] == User.emptyy)
                    {
                        return board_clear = true;
                    }
                }
            }
            return board_clear = false;
        }


        

        public void CheckKey(int _sizeBoard, KeyEventArgs _key1)
        {
            check_move = false;

            if (_key1.Key == System.Windows.Input.Key.W || _key1.Key == System.Windows.Input.Key.Up)
            {
                for (check_x = 0; check_x <= _sizeBoard; check_x++)
                {
                    for (check_y = 0; check_y <= _sizeBoard; check_y++)
                    {
                        check_next_y = check_y + 1;

                        // sprawdzamy wiersze od ostatniego do pierwszego
                        for (int max = _sizeBoard; max >= check_next_y; max--)
                        {
                            falsee = 0;
                            // jezeli 1 i ostatni wiersz jest taki sam  i czy ostatni nie jest zerem
                            if (User.board[check_y, check_x] == User.board[max, check_x] && User.board[max, check_x] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnim wierszem
                                ++check_next_y;
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                check_next_y--;
                                // jezeli srodkowe wiersze sa puste
                                if (falsee == User.emptyy)
                                {
                                    // dodanie komorki wiersza 1 i ostatniego
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // ostatnia komorke wiersza wypelniamy zerem
                                    User.board[max, check_x] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli ostatni wiersz nie jest zerem a pierwszy jest pusty
                            else if(User.board[max, check_x] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnim wierszem
                                ++check_next_y;
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                check_next_y--;
                                // jezeli srodkowe wiersze sa puste
                                if (falsee == User.emptyy)
                                {
                                    // wstaw zawartosc wiersza ostatniego do pierwszego wiersza
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // ostatni wiersz wypelnij zerem
                                    User.board[max, check_x] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli pierwszy wiersz i nastepny sa takie same i czy następny nie jest zerem
                            else if(User.board[check_y, check_x] == User.board[check_next_y, check_x] && User.board[check_next_y, check_x] != User.emptyy)
                            {
                                // dodaj pierszy i kolejny wiersz
                                User.board[check_y, check_x] += User.board[check_next_y, check_x];
                                // kolejny wiersz wypelnij zerem
                                User.board[check_next_y, check_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                            // jezeli pierwszy wiersz jest pusty a nastepny nie jest
                            else if(User.board[check_y, check_x] == 0 && User.board[check_next_y, check_x] != User.emptyy)
                            {
                                //wstaw zawartosc wiersza nastepnego w miejsce pierwszego
                                User.board[check_y, check_x] += User.board[check_next_y, check_x];
                                // nastepny wiersz wypelni zerem
                                User.board[check_next_y, check_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                        }
                    }
                }
            }

            if (_key1.Key == System.Windows.Input.Key.A || _key1.Key == System.Windows.Input.Key.Left)
            {
                for (check_x = 0; check_x <= _sizeBoard; check_x++)
                {
                    for (check_y = 0; check_y <= _sizeBoard; check_y++)
                    {
                        check_next_x = check_x + 1;

                        // sprawdzamy kolumny od ostatniego do pierwszego
                        for (int max = _sizeBoard; max >= check_next_x; max--)
                        {
                            falsee = 0;
                            // jezeli 1 i ostatna kolumna jest taka sama i czy ostatna nie jest zerem
                            if (User.board[check_y, check_x] == User.board[check_y, max] && User.board[check_y, max] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnia kolumna
                                ++check_next_x;
                                for (int i = check_next_x; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                check_next_x--;
                                // jezeli srodkowe kolumny sa puste
                                if (falsee == User.emptyy)
                                {
                                    // dodanie komorki kolumny 1 i ostatniej
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    // ostatnia komorke kolumny wypelniamy zerem
                                    User.board[check_y, max] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli ostatna kolumna nie jest zerem a pierwsza jest pusta
                            else if (User.board[check_y, max] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnia kolumna
                                ++check_next_x;
                                for (int i = check_next_x; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                check_next_x--;
                                // jezeli srodkowe kolumny sa puste
                                if (falsee == User.emptyy)
                                {
                                    // wstaw zawartosc kolumny ostatniej do pierwszej kolumny
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    // ostatna kolumne wypelnij zerem
                                    User.board[check_y, max] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli pierwsza kolumna i nastepna sa takie same i czy następna nie jest zerem
                            else if (User.board[check_y, check_x] == User.board[check_y, check_next_x] && User.board[check_y, check_next_x] != User.emptyy)
                            {
                                // dodaj piersza i kolejna kolumne
                                User.board[check_y, check_x] += User.board[check_y, check_next_x];
                                // kolejna kolumne wypelnij zerem
                                User.board[check_y, check_next_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                            // jezeli pierwsza kolumna jest pusta a nastepna nie jest
                            else if (User.board[check_y, check_x] == 0 && User.board[check_y, check_next_x] != User.emptyy)
                            {
                                //wstaw zawartosc kolumny nastepnej w miejsce pierwszej
                                User.board[check_y, check_x] += User.board[check_y, check_next_x];
                                // nastepny wiersz wypelni zerem
                                User.board[check_y, check_next_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
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
