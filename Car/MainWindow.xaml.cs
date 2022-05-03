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

namespace Car
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        camion Scania;
        camion Mercedes;

        public MainWindow()
        {
            InitializeComponent();

            Scania = new camion(10000, 200, 30);
            Scania.Znacka = "Scania";

            Mercedes = new camion(10000, 220, 32);
            Mercedes.Znacka = "Mercedes";

            kamion1.Text = Scania.Znacka + "\n";
            kamion1.Text = "Nosnost" + Scania.Nosnost + "\n";
            kamion1.Text = "Naložení" + Scania.Naložení + "\n";
            kamion1.Text = "Spotreba" + Scania.Spotreba + "\n";
            kamion1.Text = "ObjemNadrze" + Scania.ObjemNádrže + "\n";
            kamion1.Text = "Palivo" + Scania.Palivo + "\n";
            kamion1.Text = "Vzdálenost" + Scania.Vzdalenost + "\n";

        }
        

    }
}
