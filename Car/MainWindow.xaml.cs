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

            Scania = new camion(10000, 300, 30);
            Scania.Znacka = "Scania";

            Mercedes = new camion(10000, 220, 32);
            Mercedes.Znacka = "Mercedes";

            vypis();
        }
        public void vypis()
        {
            kamion1.Text = Scania.Znacka + "\n";
            kamion1.Text += "Nosnost" + " " + Scania.Nosnost + "\n";
            kamion1.Text += "Naložení" + " " + Scania.Naložení + "\n";
            kamion1.Text += "Spotreba" + " " + Scania.Spotreba + "\n";
            kamion1.Text += "ObjemNadrze" + " " + Scania.ObjemNádrže + "\n";
            kamion1.Text += "Palivo" + " " + Scania.Palivo + "\n";
            kamion1.Text += "Vzdálenost" + " " + Scania.Vzdalenost + "\n";

            kamion2.Text = Mercedes.Znacka + "\n";
            kamion2.Text += "Nosnost" + " " + Mercedes.Nosnost + "\n";
            kamion2.Text += "Naložení" + " " + Mercedes.Naložení + "\n";
            kamion2.Text += "Spotreba" + " " + Mercedes.Spotreba + "\n";
            kamion2.Text += "ObjemNadrze" + " " + Mercedes.ObjemNádrže + "\n";
            kamion2.Text += "Palivo" + " " + Mercedes.Palivo + "\n";
            kamion2.Text += "Vzdálenost" + " " + Mercedes.Vzdalenost + "\n";
        }

        private void Jet_Click(object sender, RoutedEventArgs e)
        {
            Scania.Jet(int.Parse(input1.Text));
            vypis();
        }

        private void Natankovat_Click(object sender, RoutedEventArgs e)
        {
            Scania.Tankovat(int.Parse(input1.Text));
            vypis();
        }

        private void Natankovat2_Click(object sender, RoutedEventArgs e)
        {
            Mercedes.Tankovat(int.Parse(Input2.Text));
            vypis();
        }

        private void nalozit_Click(object sender, RoutedEventArgs e)
        {
            Scania.Naloz(int.Parse(input1.Text));
            vypis();
        }

        private void vylozit_Click(object sender, RoutedEventArgs e)
        {
            Scania.Vyloz(int.Parse(input1.Text));
            vypis();
        }

        private void nalozit2_Click(object sender, RoutedEventArgs e)
        {
            Mercedes.Naloz(int.Parse(Input2.Text));
            vypis();
        }

        private void Vylozit2_Click(object sender, RoutedEventArgs e)
        {
            Mercedes.Vyloz(int.Parse(Input2.Text));
            vypis();
        }

        private void Jet2_Click(object sender, RoutedEventArgs e)
        {

            Mercedes.Jet(int.Parse(Input2.Text));
            vypis();
        }
    }
}
