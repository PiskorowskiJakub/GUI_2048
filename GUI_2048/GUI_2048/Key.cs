//  Created by Jakub Piskorowski on 20/05/2018
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
        public int check_x = 0;                  // sprawdzenie po zmiennej x

        public int check_next_y = 0;            // zmenna pomocnicza
        public int check_next_x = 0;            // zmenna pomocnicza
        public int check_priev_x = 0;            // zmenna pomocnicza
        public int check_priev_y = 0;            // zmenna pomocnicza
        

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

                        // sprawdzamy wiersze od pierwszego do ostatniego
                        for (int max = check_next_y; max <= _sizeBoard; max++)
                        {
                            falsee = 0;
                            // jezeli 1 i ostatni wiersz jest taki sam  i czy ostatni nie jest zerem
                            if (User.board[check_y, check_x] == User.board[max, check_x] && User.board[max, check_x] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnim wierszem
                                //++check_next_y;
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_y--;
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
                                //++check_next_y;
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_y--;
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

                        // sprawdzamy kolumny od pierwszego do ostatniego
                        for (int max = check_next_x; max <= _sizeBoard; max++)
                        {
                            falsee = 0;
                            // jezeli 1 i ostatna kolumna jest taka sama i czy ostatna nie jest zerem
                            if (User.board[check_y, check_x] == User.board[check_y, max] && User.board[check_y, max] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnia kolumna
                                //++check_next_x;
                                for (int i = check_next_x; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_x--;
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
                                //++check_next_x;
                                for (int i = check_next_x; i < max; i++)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_x--;
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
          


            if (_key1.Key == System.Windows.Input.Key.D || _key1.Key == System.Windows.Input.Key.Right)
            {
                for (check_x = _sizeBoard; check_x >= 0; check_x--)
                {
                    for (check_y = _sizeBoard; check_y >= 0; check_y--)
                    {
                        check_priev_x = check_x - 1;

                        // sprawdzamy kolumny od ostatniego do pierwszego
                        for (int max = check_priev_x; max >= 0; max--)
                        {
                            falsee = 0;
                            // jezeli ostatnia i pierwsza kolumna jest taka sama i czy pierwsza nie jest zerem
                            if (User.board[check_y, check_x] == User.board[check_y, max] && User.board[check_y, max] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnia kolumna
                                //--check_priev_x;
                                for (int i = check_priev_x; i < max; i--)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_priev_x++;
                                // jezeli srodkowe kolumny sa puste
                                if (falsee == User.emptyy)
                                {
                                    // dodanie komorki kolumny ostatniej i pierwszej
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    // pierwsza komorke kolumny wypelniamy zerem
                                    User.board[check_y, max] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli pierwsza kolumna nie jest zerem a ostatnia jest pusta
                            else if (User.board[check_y, max] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnia kolumna
                                //--check_priev_x;
                                for (int i = check_priev_x; i < max; i--)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_priev_x++;
                                // jezeli srodkowe kolumny sa puste
                                if (falsee == User.emptyy)
                                {
                                    // wstaw zawartosc kolumny pierwszej do ostatniej kolumny
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    // pierwsza kolumne wypelnij zerem
                                    User.board[check_y, max] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli ostatnia kolumna i poprzednia sa takie same i czy poprzednia nie jest zerem
                            else if (User.board[check_y, check_x] == User.board[check_y, check_priev_x] && User.board[check_y, check_priev_x] != User.emptyy)
                            {
                                // dodaj ostatnia i poprzednia kolumne
                                User.board[check_y, check_x] += User.board[check_y, check_priev_x];
                                // poprzednia kolumne wypelnij zerem
                                User.board[check_y, check_priev_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                            // jezeli ostatnia kolumna jest pusta a poprzednia nie jest
                            else if (User.board[check_y, check_x] == 0 && User.board[check_y, check_priev_x] != User.emptyy)
                            {
                                //wstaw zawartosc kolumny poprzedniej w miejsce ostatniej
                                User.board[check_y, check_x] += User.board[check_y, check_priev_x];
                                // poprzedni wiersz wypelni zerem
                                User.board[check_y, check_priev_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                        }
                    }
                }
            }



            if (_key1.Key == System.Windows.Input.Key.S || _key1.Key == System.Windows.Input.Key.Down)
            {
                for (check_x = _sizeBoard; check_x >= 0; check_x--)
                {
                    for (check_y = _sizeBoard; check_y >= 0; check_y--)
                    {
                        check_priev_y = check_y - 1;

                        // sprawdzamy wiersze od ostatniego do pierwszego
                        for (int max = check_priev_y; max >= 0; max--)
                        {
                            falsee = 0;
                            // jezeli ostatni i pierwszy wiersz jest taki sam  i czy pierwszy nie jest zerem
                            if (User.board[check_y, check_x] == User.board[max, check_x] && User.board[max, check_x] != User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy ostatnim a 2 wierszem
                                //++check_next_y;
                                for (int i = check_priev_y; i < max; i--)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_y--;
                                // jezeli srodkowe wiersze sa puste
                                if (falsee == User.emptyy)
                                {
                                    // dodanie komorki wiersza ostatniego i pierwszego
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // pierwsza komorke wiersza wypelniamy zerem
                                    User.board[max, check_x] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli pierwszy wiersz nie jest zerem a ostatni jest pusty
                            else if (User.board[max, check_x] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // sprawdzamy elementy tablicy miedzy 2 a ostatnim wierszem
                                //++check_next_y;
                                for (int i = check_priev_y; i < max; i--)
                                {
                                    // jezeli nie jest puste
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                //check_next_y--;
                                // jezeli srodkowe wiersze sa puste
                                if (falsee == User.emptyy)
                                {
                                    // wstaw zawartosc wiersza pierwszego do ostatniego wiersza
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // pierwszy wiersz wypelnij zerem
                                    User.board[max, check_x] = User.emptyy;
                                    // potwierdzenie ze ruch zostal wykonany
                                    check_move = true;
                                }
                            }
                            // jezeli ostatni wiersz i poprzedni sa takie same i czy poprzedni nie jest zerem
                            else if (User.board[check_y, check_x] == User.board[check_priev_y, check_x] && User.board[check_priev_y, check_x] != User.emptyy)
                            {
                                // dodaj ostatni i poprzedni wiersz
                                User.board[check_y, check_x] += User.board[check_priev_y, check_x];
                                // poprzedni wiersz wypelnij zerem
                                User.board[check_priev_y, check_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                            // jezeli ostatni wiersz jest pusty a poprzedni nie jest
                            else if (User.board[check_y, check_x] == 0 && User.board[check_priev_y, check_x] != User.emptyy)
                            {
                                //wstaw zawartosc wiersza poprzedniego w miejsce ostatniego
                                User.board[check_y, check_x] += User.board[check_priev_y, check_x];
                                // poprzedni wiersz wypelni zerem
                                User.board[check_priev_y, check_x] = User.emptyy;
                                // potwierdzenie ze ruch zostal wykonany
                                check_move = true;
                            }
                        }
                    }
                }
            }


            


        }


    }
}
