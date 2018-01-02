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



        private void KeyDown_Event(object sender, KeyEventArgs e)   // aktualizacja danych
        {
            

            Board.RandValue();    // losuje wartość 2 lub 4

            Key.CheckKey(sizeBoard, e);    // sprawdzanie klawisza i wykonanie ruchu 

            Key.Checkclear();   // sprawdzenie czy sa puste pola 

            if (Key.check_move > 0)         // Jesli wykonano jakis ruch
            {
                Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby      
            }

            Board.ConvertBytes();   // zamiana liczb na bajty
            Board.UpdateBoard();      // Wprowadź nowe wartości do tablicy

        }


        public Plansza6x6()     // Inicjalizacja GUI
        {
          //  InitializeComponent();


            

            sizeBoard = 3;
 
            User.CreateBoard(sizeBoard);     // wypełnienie tablicy zerami

            Board.RandValue();    // losuje wartość 2 lub 4

            Board.RandCoordinates(sizeBoard);     // losowanie wspolrzednych nowej liczby

            Board.ConvertBytes();   // zamiana liczba na bajty
            Board.UpdateBoard();    // wyswietlenie zawartosci tablicy

        }

        private void wyjscie(object sender, RoutedEventArgs e)
        {
            MainWindow wyjscie = new MainWindow();
            wyjscie.Show();
            this.Close();
        }
    }
}
