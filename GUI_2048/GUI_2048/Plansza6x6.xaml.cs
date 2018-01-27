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
    /// <summary>
    /// Interaction logic for Plansza4x4.xaml
    /// </summary>
    public partial class Plansza6x6 : Window
    {
        /*
        public int pause; // zmienna tymczasowa
        
        public static int menu, sizeBoard;
        public int button;             //klawisz
        public int historyXcoordinate1, historyYcoordinate1;
        public int historyXcoordinate2, historyYcoordinate2;
        public static string exitt;
  
        */



        public System.Windows.Media.SolidColorBrush ChangeBackground(int a, int b)
        {
            //var checkBg = Brushes.White; 
            switch (User.board[a, b])
            {
                case 0: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff"));
                case 2: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffe8cc"));
                case 4: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffe8cc"));
                case 8: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffe8cc"));
                case 16: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffddb3"));
                case 32: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffddb3"));
                case 64: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffddb3"));
                case 128: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffd199"));
                case 256: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffd199"));
                case 512: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffd199"));
                case 1024: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffba66"));
                case 2048: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffaf4d"));
                case 4096: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e67300"));
                case 8192: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f2460d"));
                case 16384: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#d44211"));
                case 32768: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e23636"));
                case 65536: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f65555"));
                case 131072: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f42525"));
                case 262144: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#cc0000"));
                case 524288: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ff0000"));

                default: return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff"));
            }

        }

        public int checkAchiv = 0;
        public int sizeBoard;

        User User = new User();
        Board Board = new Board();
        Key Key = new Key();

        public void UpdateBoard()
        {
            area_00.Background = ChangeBackground(0, 0);
            area_10.Background = ChangeBackground(1, 0);
            area_20.Background = ChangeBackground(2, 0);
            area_30.Background = ChangeBackground(3, 0);
            area_40.Background = ChangeBackground(4, 0);
            area_50.Background = ChangeBackground(5, 0);

            area_01.Background = ChangeBackground(0, 1);
            area_11.Background = ChangeBackground(1, 1);
            area_21.Background = ChangeBackground(2, 1);
            area_31.Background = ChangeBackground(3, 1);
            area_41.Background = ChangeBackground(4, 1);
            area_51.Background = ChangeBackground(5, 1);

            area_02.Background = ChangeBackground(0, 2);
            area_12.Background = ChangeBackground(1, 2);
            area_22.Background = ChangeBackground(2, 2);
            area_32.Background = ChangeBackground(3, 2);
            area_42.Background = ChangeBackground(4, 2);
            area_52.Background = ChangeBackground(5, 2);

            area_03.Background = ChangeBackground(0, 3);
            area_13.Background = ChangeBackground(1, 3);
            area_23.Background = ChangeBackground(2, 3);
            area_33.Background = ChangeBackground(3, 3);
            area_43.Background = ChangeBackground(4, 3);
            area_53.Background = ChangeBackground(5, 3);

            area_04.Background = ChangeBackground(0, 4);
            area_14.Background = ChangeBackground(1, 4);
            area_24.Background = ChangeBackground(2, 4);
            area_34.Background = ChangeBackground(3, 4);
            area_44.Background = ChangeBackground(4, 4);
            area_54.Background = ChangeBackground(5, 4);

            area_05.Background = ChangeBackground(0, 5);
            area_15.Background = ChangeBackground(1, 5);
            area_25.Background = ChangeBackground(2, 5);
            area_35.Background = ChangeBackground(3, 5);
            area_45.Background = ChangeBackground(4, 5);
            area_55.Background = ChangeBackground(5, 5);


            cell_00.Text = Board.output[0, 0];
            cell_10.Text = Board.output[1, 0];
            cell_20.Text = Board.output[2, 0];
            cell_30.Text = Board.output[3, 0];
            cell_40.Text = Board.output[4, 0];
            cell_50.Text = Board.output[5, 0];

            cell_01.Text = Board.output[0, 1];
            cell_11.Text = Board.output[1, 1];
            cell_21.Text = Board.output[2, 1];
            cell_31.Text = Board.output[3, 1];
            cell_41.Text = Board.output[4, 1];
            cell_51.Text = Board.output[5, 1];

            cell_02.Text = Board.output[0, 2];
            cell_12.Text = Board.output[1, 2];
            cell_22.Text = Board.output[2, 2];
            cell_32.Text = Board.output[3, 2];
            cell_42.Text = Board.output[4, 2];
            cell_52.Text = Board.output[5, 2];

            cell_03.Text = Board.output[0, 3];
            cell_13.Text = Board.output[1, 3];
            cell_23.Text = Board.output[2, 3];
            cell_33.Text = Board.output[3, 3];
            cell_43.Text = Board.output[4, 3];
            cell_53.Text = Board.output[5, 3];

            cell_04.Text = Board.output[0, 4];
            cell_14.Text = Board.output[1, 4];
            cell_24.Text = Board.output[2, 4];
            cell_34.Text = Board.output[3, 4];
            cell_44.Text = Board.output[4, 4];
            cell_54.Text = Board.output[5, 4];

            cell_05.Text = Board.output[0, 5];
            cell_15.Text = Board.output[1, 5];
            cell_25.Text = Board.output[2, 5];
            cell_35.Text = Board.output[3, 5];
            cell_45.Text = Board.output[4, 5];
            cell_55.Text = Board.output[5, 5];
        }

        public void CheckAchiv(int _sizeboard)
        {
            for (int i = 0; i <= _sizeboard; i += 1)
            {
                for (int j = 0; j <= _sizeboard; j += 1)
                {
                    switch (User.board[i, j])
                    {
                        case 128: if (checkAchiv == 0) { MessageBox.Show("Pierwsze kroki"); checkAchiv = 1; } break;
                        case 512: if (checkAchiv == 1) { MessageBox.Show("Moja babcia doszła by dalej :P"); checkAchiv = 2; } break;
                        case 1024: if (checkAchiv == 2) { MessageBox.Show("Chyba nie klikasz losowo?"); checkAchiv = 3; } break;
                        case 2048: if (checkAchiv == 3) { MessageBox.Show("Czy to już koniec?"); checkAchiv = 4; } break;
                        case 4096: if (checkAchiv == 4) { MessageBox.Show("Czy to jeszcze działa?"); checkAchiv = 5; } break;
                        case 8192: if (checkAchiv == 5) { MessageBox.Show("Pojawiam się i znikam. Taka rola magika"); checkAchiv = 6; } break;
                        case 16384: if (checkAchiv == 6) { MessageBox.Show("„Ja tu byłem :D” – Jacob.exe"); checkAchiv = 7; } break;
                        case 32768: if (checkAchiv == 7) { MessageBox.Show("Jestem farmerem!"); checkAchiv = 8; } break;
                        case 65536: if (checkAchiv == 8) { MessageBox.Show("Choćbym chodził ciemną doliną…"); checkAchiv = 9; } break;
                        case 131072: if (checkAchiv == 9) { MessageBox.Show("Wybraniec"); checkAchiv = 10; } break;
                        case 262144: if (checkAchiv == 10) { MessageBox.Show("GOD AMONGST MAN!"); checkAchiv = 11; } break;
                        case 524288: if (checkAchiv == 11) { MessageBox.Show("#$@_ERROR_#*@"); checkAchiv = 12; } break;
                    }
                }
            }
        }

        private void KeyDown_Event(object sender, KeyEventArgs e)   // aktualizacja danych
        {


            Key.Checkclear(sizeBoard);   // sprawdzenie czy sa puste pola 

            if (Key.board_clear == false)
            {
                MessageBox.Show("Koniec Gry");
                MainWindow wyjscie = new MainWindow();
                wyjscie.Show();
                this.Close();
            }

            Key.CheckKey(sizeBoard, e);    // sprawdzanie klawisza i wykonanie ruchu 

            if (Key.check_move == true)         // Jesli wykonano jakis ruch
            {
                Board.RandValue();    // losuje wartość 2 lub 4
                Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby      
            }

            Board.ConvertBytes(sizeBoard);   // zamiana liczb na bajty

            UpdateBoard();      // Wprowadź nowe wartości do tablicy
            CheckAchiv(sizeBoard);      // wyswietlenie Achivmenta
        }


        public Plansza6x6()     // Inicjalizacja GUI
        {
            InitializeComponent();


            sizeBoard = 5;

            User.CreateBoard(sizeBoard);     // wypełnienie tablicy zerami
            for (int i = 0; i < 2; i++)
            {
                Board.RandValue();    // losuje wartość 2 lub 4
                Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby
            }

            Board.ConvertBytes(sizeBoard);   // zamiana liczba na bajty
            UpdateBoard();    // wyswietlenie zawartosci tablicy

        }

        private void wyjscie(object sender, RoutedEventArgs e)
        {
            MainWindow wyjscie = new MainWindow();
            wyjscie.Show();
            this.Close();
        }
    }
}
