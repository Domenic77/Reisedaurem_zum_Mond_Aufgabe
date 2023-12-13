using Reisedauer_zum_Mond_Aufgabe;
using System;
using System.Windows.Forms;

namespace Reisedaurem_zum_Mond_Aufgabe
{
    public partial class Form1 : Form
    {
        Mondreise mondreise = new Mondreise(1500);

        public Form1()
        {
            InitializeComponent();
        }



        private void InStundenradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            double speedKmh = Convert.ToDouble(Geschwindigkeit.Text);
            double result;

            if (InStundenradioButton.Checked == true)
            {
                result = mondreise.BerechnenStunden();
            }
            else
            {
                result = mondreise.BerechnenTage();
            }

            Ausgabe.Text = result.ToString();
        }
    }
}

