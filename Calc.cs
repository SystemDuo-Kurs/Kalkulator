using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc : INotifyPropertyChanged
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Rezultat { get; set; } = 100;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void Operacija(string op)
        {
            switch (op)
            {
                case "+":
                    Rezultat = X + Y;
                    break;

                case "-":
                    Rezultat = X - Y;
                    break;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rezultat"));
        }
    }
}