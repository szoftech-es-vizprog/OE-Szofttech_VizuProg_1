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

namespace ElsoOra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Ablak címének beállítása
            this.Title = "Hello Világ!";

            // Szöveg mező beállítása
            Text1.Content = "Hello Világ!";

            //Szövegmező betűtipusának beállítása
            Text1.FontFamily = new FontFamily("Arial");

            // checkbox alapján történő szöveg beállítás
            if (check1.IsChecked.Value) {
                Text1.Content = "Hello Checkbox!";
            }

            // Háttérkép beállítása az ablaknak az internetről
            //Háttér betöltése az ecsetbe
            ImageBrush myImageBrush = new ImageBrush();
            myImageBrush.ImageSource = new BitmapImage(
            new Uri(BaseUriHelper.GetBaseUri(this),
            "http://www.gamechannel.hu/pictures/hirblock/tovabbra_is_a_windows_xp_a_masodik_legnepszerubb_windows_1.jpg"
            ));
            // Háttér beállítása
            this.Background = myImageBrush;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Ablak címének vissza állítása
            this.Title = "Main Window!";

            // Radiohoz tartozó textbox ürítése
            Valasztot("");

            //Háttér visszaállítása fehérre
            this.Background = Brushes.White;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // "TIK" Radio gomb lenyomásakor szöveg beállítása a Választott függvényewn keresztül
            String RadioSelected = "Tik";
            Valasztot(RadioSelected);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            // "TAK" Radio gomb lenyomásakor szöveg beállítása a Választott függvényewn keresztül
            String RadioSelected = "Tak";
            Valasztot(RadioSelected);
        }

        //Radio gombhoz tartozó label beállítása a kapott paraméter alapján
        private void Valasztot(String RadioSelected) {
            switch (RadioSelected) {
                case "Tik":

                    RadioLabel.Content = "TIK";
                    break;
                case "Tak":

                    RadioLabel.Content = "TAK";
                    break;
                default:
                    RadioLabel.Content = "ERROR";
                    break;
            }
        }

        // Gomb lenyomáskor kiolvassa a textbox tartalmázt és csak a listában szereplő betűket írja ki a beviteli mező alá.
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // Kiírandó elemek listája, angol maganhangzok
            List<Key> maganhangzok = new List<Key>();
            maganhangzok.Add(Key.A);
            maganhangzok.Add(Key.E);
            maganhangzok.Add(Key.O);
            maganhangzok.Add(Key.I);
            maganhangzok.Add(Key.U);

            //Amennyiben eleme a listának az adott billentyű, úgy hozzáadó a szöveg dobozhoz
            if (maganhangzok.Contains(e.Key)) {
                TextBoxLabel.Content = TextBoxLabel.Content + e.Key.ToString();

            }
        }

        // Textbox kitöltő szöveg eltávolítása, amikor bele kattintunk, tehát fókuszt kap.
        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
        }
    }
}
