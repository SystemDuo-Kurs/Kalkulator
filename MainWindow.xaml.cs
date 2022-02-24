using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            stek2.DataContext = new Calc();

            //Ovo radi labela pri bindingu
            Calc cl = new();

            if (cl is INotifyPropertyChanged npc)
            {
                npc.PropertyChanged += Foo;
            }

            cl.X = 12;
            cl.Y = 34;
            cl.Operacija("+");
        }

        public void Foo(object zklj, PropertyChangedEventArgs p)
        {
            MessageBox.Show($"Promenjeno {p.PropertyName}");
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
                c.Operacija("+");
            }
        }

        private void Sabiranje2(object sender, RoutedEventArgs zklj)
        {
            if (stek2.DataContext is Calc c)
            {
                c.Operacija("+");
            }
        }

        private void Oduzimanje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Operacija("-");
            }
        }
    }
}