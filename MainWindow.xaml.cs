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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Calc();
        }

        //TODO Izmeniti klasu Calc, tako da ima svih 5 operacija (+,-,*,/, modulus :P )
        //ALIIIIIIIIIIIIIIIIIIIIII
        //Svih pet mora da se rade iz iste metode
        //tako sto ce ta medtoda imati string kao ulazni parametar
        //i switch case ili if da zna sta treba da radi :)

        private void Sabiranje(object sender, RoutedEventArgs zklj)
        {
            if (DataContext is Calc c)
            {
                c.Sabiranje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }

        private void Oduzimanje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Oduzimanje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
    }
}