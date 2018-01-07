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





        



        public int sizeBoard;

        User User = new User();
        Board Board = new Board();
        Key Key = new Key();

        public void UpdateBoard()
        {
           
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



        private void KeyDown_Event(object sender, KeyEventArgs e)   // aktualizacja danych
        {
            
/*
            Board.RandValue();    // losuje wartość 2 lub 4

            Key.CheckKey(sizeBoard, e);    // sprawdzanie klawisza i wykonanie ruchu 

            Key.Checkclear();   // sprawdzenie czy sa puste pola 

            if (Key.check_move > 0)         // Jesli wykonano jakis ruch
            {
                Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby      
            }

            Board.ConvertBytes();   // zamiana liczb na bajty
            Board.UpdateBoard();      // Wprowadź nowe wartości do tablicy
*/
        }


        public Plansza6x6()     // Inicjalizacja GUI
        {
            InitializeComponent();


            

            sizeBoard = 5;
 
            User.CreateBoard(sizeBoard);     // wypełnienie tablicy zerami

            Board.RandValue();    // losuje wartość 2 lub 4

            Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby

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
