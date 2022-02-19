using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Rezultat { get; set; }

        public void Sabiranje()
        {
            Rezultat = X + Y;
        }

        public void Oduzimanje()
        {
            Rezultat = X - Y;
        }
    }
}