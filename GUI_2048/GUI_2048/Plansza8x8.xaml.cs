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
    public partial class Plansza8x8 : Window
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
            area_60.Background = ChangeBackground(6, 0);
            area_70.Background = ChangeBackground(7, 0);

            area_01.Background = ChangeBackground(0, 1);
            area_11.Background = ChangeBackground(1, 1);
            area_21.Background = ChangeBackground(2, 1);
            area_31.Background = ChangeBackground(3, 1);
            area_41.Background = ChangeBackground(4, 1);
            area_51.Background = ChangeBackground(5, 1);
            area_61.Background = ChangeBackground(6, 1);
            area_71.Background = ChangeBackground(7, 1);

            area_02.Background = ChangeBackground(0, 2);
            area_12.Background = ChangeBackground(1, 2);
            area_22.Background = ChangeBackground(2, 2);
            area_32.Background = ChangeBackground(3, 2);
            area_42.Background = ChangeBackground(4, 2);
            area_52.Background = ChangeBackground(5, 2);
            area_62.Background = ChangeBackground(6, 2);
            area_72.Background = ChangeBackground(7, 2);

            area_03.Background = ChangeBackground(0, 3);
            area_13.Background = ChangeBackground(1, 3);
            area_23.Background = ChangeBackground(2, 3);
            area_33.Background = ChangeBackground(3, 3);
            area_43.Background = ChangeBackground(4, 3);
            area_53.Background = ChangeBackground(5, 3);
            area_63.Background = ChangeBackground(6, 3);
            area_73.Background = ChangeBackground(7, 3);

            area_04.Background = ChangeBackground(0, 4);
            area_14.Background = ChangeBackground(1, 4);
            area_24.Background = ChangeBackground(2, 4);
            area_34.Background = ChangeBackground(3, 4);
            area_44.Background = ChangeBackground(4, 4);
            area_54.Background = ChangeBackground(5, 4);
            area_64.Background = ChangeBackground(6, 4);
            area_74.Background = ChangeBackground(7, 4);

            area_05.Background = ChangeBackground(0, 5);
            area_15.Background = ChangeBackground(1, 5);
            area_25.Background = ChangeBackground(2, 5);
            area_35.Background = ChangeBackground(3, 5);
            area_45.Background = ChangeBackground(4, 5);
            area_55.Background = ChangeBackground(5, 5);
            area_65.Background = ChangeBackground(6, 5);
            area_75.Background = ChangeBackground(7, 5);

            area_06.Background = ChangeBackground(0, 6);
            area_16.Background = ChangeBackground(1, 6);
            area_26.Background = ChangeBackground(2, 6);
            area_36.Background = ChangeBackground(3, 6);
            area_46.Background = ChangeBackground(4, 6);
            area_56.Background = ChangeBackground(5, 6);
            area_66.Background = ChangeBackground(6, 6);
            area_76.Background = ChangeBackground(7, 6);

            area_07.Background = ChangeBackground(0, 7);
            area_17.Background = ChangeBackground(1, 7);
            area_27.Background = ChangeBackground(2, 7);
            area_37.Background = ChangeBackground(3, 7);
            area_47.Background = ChangeBackground(4, 7);
            area_57.Background = ChangeBackground(5, 7);
            area_67.Background = ChangeBackground(6, 7);
            area_77.Background = ChangeBackground(7, 7);


            cell_00.Text = Board.output[0, 0];
            cell_10.Text = Board.output[1, 0];
            cell_20.Text = Board.output[2, 0];
            cell_30.Text = Board.output[3, 0];
            cell_40.Text = Board.output[4, 0];
            cell_50.Text = Board.output[5, 0];
            cell_60.Text = Board.output[6, 0];
            cell_70.Text = Board.output[7, 0];

            cell_01.Text = Board.output[0, 1];
            cell_11.Text = Board.output[1, 1];
            cell_21.Text = Board.output[2, 1];
            cell_31.Text = Board.output[3, 1];
            cell_41.Text = Board.output[4, 1];
            cell_51.Text = Board.output[5, 1];
            cell_61.Text = Board.output[6, 1];
            cell_71.Text = Board.output[7, 1];

            cell_02.Text = Board.output[0, 2];
            cell_12.Text = Board.output[1, 2];
            cell_22.Text = Board.output[2, 2];
            cell_32.Text = Board.output[3, 2];
            cell_42.Text = Board.output[4, 2];
            cell_52.Text = Board.output[5, 2];
            cell_62.Text = Board.output[6, 2];
            cell_72.Text = Board.output[7, 2];

            cell_03.Text = Board.output[0, 3];
            cell_13.Text = Board.output[1, 3];
            cell_23.Text = Board.output[2, 3];
            cell_33.Text = Board.output[3, 3];
            cell_43.Text = Board.output[4, 3];
            cell_53.Text = Board.output[5, 3];
            cell_63.Text = Board.output[6, 3];
            cell_73.Text = Board.output[7, 3];

            cell_04.Text = Board.output[0, 4];
            cell_14.Text = Board.output[1, 4];
            cell_24.Text = Board.output[2, 4];
            cell_34.Text = Board.output[3, 4];
            cell_44.Text = Board.output[4, 4];
            cell_54.Text = Board.output[5, 4];
            cell_64.Text = Board.output[6, 4];
            cell_74.Text = Board.output[7, 4];

            cell_05.Text = Board.output[0, 5];
            cell_15.Text = Board.output[1, 5];
            cell_25.Text = Board.output[2, 5];
            cell_35.Text = Board.output[3, 5];
            cell_45.Text = Board.output[4, 5];
            cell_55.Text = Board.output[5, 5];
            cell_65.Text = Board.output[6, 5];
            cell_75.Text = Board.output[7, 5];

            cell_06.Text = Board.output[0, 6];
            cell_16.Text = Board.output[1, 6];
            cell_26.Text = Board.output[2, 6];
            cell_36.Text = Board.output[3, 6];
            cell_46.Text = Board.output[4, 6];
            cell_56.Text = Board.output[5, 6];
            cell_66.Text = Board.output[6, 6];
            cell_76.Text = Board.output[7, 6];

            cell_07.Text = Board.output[0, 7];
            cell_17.Text = Board.output[1, 7];
            cell_27.Text = Board.output[2, 7];
            cell_37.Text = Board.output[3, 7];
            cell_47.Text = Board.output[4, 7];
            cell_57.Text = Board.output[5, 7];
            cell_67.Text = Board.output[6, 7];
            cell_77.Text = Board.output[7, 7];
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
                        case 8192: if (checkAchiv == 5) { MessageBox.Show("Empty"); checkAchiv = 6; } break;
                        case 16384: if (checkAchiv == 6) { MessageBox.Show("„Ja tu byłem :D” – Jacob.exe"); checkAchiv = 7; } break;
                        case 32768: if (checkAchiv == 7) { MessageBox.Show("Jestem farmerem!"); checkAchiv = 8; } break;
                        case 65536: if (checkAchiv == 8) { MessageBox.Show("Empty"); checkAchiv = 9; } break;
                        case 131072: if (checkAchiv == 9) { MessageBox.Show("Choćbym chodził ciemną doliną…"); checkAchiv = 10; } break;
                        case 262144: if (checkAchiv == 10) { MessageBox.Show("Wybraniec"); checkAchiv = 11; } break;
                        case 524288: if (checkAchiv == 11) { MessageBox.Show("GOD AMONGST MAN!"); checkAchiv = 12; } break;
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


        public Plansza8x8()     // Inicjalizacja GUI
        {
              InitializeComponent();


            sizeBoard = 7;

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