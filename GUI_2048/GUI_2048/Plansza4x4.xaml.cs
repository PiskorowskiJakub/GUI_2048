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
    public partial class Plansza4x4 : Window
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

          
            cell_01.Text = Board.output[0, 1];
            cell_11.Text = Board.output[1, 1];
            cell_21.Text = Board.output[2, 1];
            cell_31.Text = Board.output[3, 1];

          
            cell_02.Text = Board.output[0, 2];
            cell_12.Text = Board.output[1, 2];
            cell_22.Text = Board.output[2, 2];
            cell_32.Text = Board.output[3, 2];

          
            cell_03.Text = Board.output[0, 3];
            cell_13.Text = Board.output[1, 3];
            cell_23.Text = Board.output[2, 3];
            cell_33.Text = Board.output[3, 3];
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

        }


        public Plansza4x4()     // Inicjalizacja GUI
        {
            InitializeComponent();

            sizeBoard = 3;
 
            User.CreateBoard(sizeBoard);     // wypełnienie tablicy zerami
            for (int i = 0; i < 2; i++)
            {
                Board.RandValue();    // losuje wartość 2 lub 4
                Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby
            }

            Board.ConvertBytes(sizeBoard);   // zamiana liczba na bajty
            UpdateBoard();    // wyswietlenie zawartosci tablicy

        }

        private void Wyjscie(object sender, RoutedEventArgs e)
        {
            MainWindow wyjscie = new MainWindow();
            wyjscie.Show();
            this.Close();
        }

        
    }
}
