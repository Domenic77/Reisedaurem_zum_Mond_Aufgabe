
using System;

namespace Reisedauer_zum_Mond_Aufgabe
{
    public class Mondreise
    {
        double speedKmh;
        int distanzmond = 384400;

        public Mondreise(double speed)
        {
            speedKmh = speed;
        }

        public double BerechnenTage()
        {
            double result = distanzmond / speedKmh / 24;
            return result;
        }

        public double BerechnenStunden()
        {
            double result = distanzmond / speedKmh;
            return result;
        }
    }
}
