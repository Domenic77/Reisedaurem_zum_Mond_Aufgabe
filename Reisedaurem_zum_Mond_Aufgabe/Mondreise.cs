
using System;

namespace Reisedauer_zum_Mond_Aufgabe
{
    public class Mondreise
    {
        double speedKmh;

        public Mondreise(double speed)
        {
            speedKmh = speed;
        }

        public double BerechnenTage()
        {
            double result = 384400 / speedKmh / 24;
            return result;
        }

        public double BerechnenStunden()
        {
            double result = 384400 / speedKmh;
            return result;
        }
    }
}
