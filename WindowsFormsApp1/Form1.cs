﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using AluCharpy;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public CharpyCalc Calculator { get; set; }
        public List<Probka> Probki;
        public Form1()
        {
            InitializeComponent();
            Calculator = new CharpyCalc();
            Probki = new List<Probka>();
        }

        private void Licz_Click(object sender, EventArgs e)
        {
            //kolumna1
            var probka1 = new Probka(1, tb1Prml.Text, tb1GruScProf.Text, tb1OdlMiWierzKarb.Text, tb1RodzPek.Text);
            Probki.Add(probka1);
            if (probka1.LiczUdarnosc())
            {
                tb1Ud.Text = probka1.Udarnosc.ToString("N4");
            }

            //kolumna2
            var probka2 = new Probka(2, tb2Prml.Text, tb2GruScProf.Text, tb2OdlMiWierzKarb.Text, tb2RodzPek.Text);
            Probki.Add(probka2);
            if (probka2.LiczUdarnosc())
            {
                tb2Ud.Text = probka2.Udarnosc.ToString("N4");
            }

            //kolumna3
            var probka3 = new Probka(3, tb3Prml.Text, tb3GruScProf.Text, tb3OdlMiWierzKarb.Text, tb3RodzPek.Text);
            Probki.Add(probka3);
            if (probka3.LiczUdarnosc())
            {
                tb3Ud.Text = probka3.Udarnosc.ToString("N4");
            }

            //todo: do 10 probek

            double[] doubleArray = new double[10];
            doubleArray= Array.ConvertAll(wynik, x => (double)x);
            
            double pom =(Calculator.StandardDeviation(doubleArray));//obliczenia na double stad castowanie
            float od_std_war= Convert.ToSingle(pom);
            float[] tab = { numVal2, numVal5, numVal8, numVal11, numVal14, numVal17, numVal20, numVal23,numVal26,numVal29 };
            float sr_grub_scianek_war = Calculator.Srednia(tab);
            float rozp_wart_udar_war = Calculator.RozpietoscWartosciUdarnosci(wynik);
            tbSrUd.Text = Convert.ToString(Calculator.Srednia(wynik));
            tbOdchStd.Text = Convert.ToString(od_std_war);
            tbEstNieo.Text = Convert.ToString(Calculator.EstymatorNieobciążonyOdchyleniaStandardowego(od_std_war));
            tbSrGrub.Text = Convert.ToString(sr_grub_scianek_war);
            tbRozpWart.Text = Convert.ToString(rozp_wart_udar_war);
            
        }

        private void tylkoliczbyHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            tb10GruScProf.Text = String.Empty;
            tb10OdlMiWierzKarb.Text = String.Empty;
            tb10Prml.Text = String.Empty;
            tb10RodzPek.Text = String.Empty;
            tb10Ud.Text = String.Empty;

            tb9GruScProf.Text = String.Empty;
            tb9OdlMiWierzKarb.Text = String.Empty;
            tb9Prml.Text = String.Empty;
            tb9RodzPek.Text = String.Empty;
            tb9Ud.Text = String.Empty;

            tb8GruScProf.Text = String.Empty;
            tb8OdlMiWierzKarb.Text = String.Empty;
            tb8Prml.Text = String.Empty;
            tb8RodzPek.Text = String.Empty;
            tb8Ud.Text = String.Empty;

            tb7GruScProf.Text = String.Empty;
            tb7OdlMiWierzKarb.Text = String.Empty;
            tb7Prml.Text = String.Empty;
            tb7RodzPek.Text = String.Empty;
            tb7Ud.Text = String.Empty;

            tb6GruScProf.Text = String.Empty;
            tb6OdlMiWierzKarb.Text = String.Empty;
            tb6Prml.Text = String.Empty;
            tb6RodzPek.Text = String.Empty;
            tb6Ud.Text = String.Empty;

            tb5GruScProf.Text = String.Empty;
            tb5OdlMiWierzKarb.Text = String.Empty;
            tb5Prml.Text = String.Empty;
            tb5RodzPek.Text = String.Empty;
            tb5Ud.Text = String.Empty;

            tb4GruScProf.Text = String.Empty;
            tb4OdlMiWierzKarb.Text = String.Empty;
            tb4Prml.Text = String.Empty;
            tb4RodzPek.Text = String.Empty;
            tb4Ud.Text = String.Empty;


            tb3GruScProf.Text = String.Empty;
            tb3OdlMiWierzKarb.Text = String.Empty;
            tb3Prml.Text = String.Empty;
            tb3RodzPek.Text = String.Empty;
            tb3Ud.Text = String.Empty;

            tb2GruScProf.Text = String.Empty;
            tb2OdlMiWierzKarb.Text = String.Empty;
            tb2Prml.Text = String.Empty;
            tb2RodzPek.Text = String.Empty;
            tb2Ud.Text = String.Empty;

            tb1GruScProf.Text = String.Empty;
            tb1OdlMiWierzKarb.Text = String.Empty;
            tb1Prml.Text = String.Empty;
            tb1RodzPek.Text = String.Empty;
            tb1Ud.Text = String.Empty;
        }

        private void Clear(Control.ControlCollection parentControl)//czyści obraz
        {
            foreach (Control control in parentControl)
            {
                Clear(control.Controls);

                if (control is TextBox)
                {                    
                    ((TextBox)control).Text = String.Empty;
                }
            } 
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano pomyślnie");
        }

        private void btnustawodlkarb_Click(object sender, EventArgs e)
        {
            tb1OdlMiWierzKarb.Text = "3,1";
            tb2OdlMiWierzKarb.Text = "3,1";
            tb3OdlMiWierzKarb.Text = "3,1";
            tb4OdlMiWierzKarb.Text = "3,1";
            tb5OdlMiWierzKarb.Text = "3,1";
            tb6OdlMiWierzKarb.Text = "3,1";
            tb7OdlMiWierzKarb.Text = "3,1";
            tb8OdlMiWierzKarb.Text = "3,1";
            tb9OdlMiWierzKarb.Text = "3,1";
            tb10OdlMiWierzKarb.Text = "3,1";
        }

        private void richTextBox2_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void wyczyscformularz_Click(object sender, EventArgs e)
        {
            Clear(this.Controls);
           
        }

        private void chpn_press(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch != 'n' && ch != 'p' && ch != 'h' && ch != 'c' && ch != 'N' && ch != 'P' && ch != 'H' && ch != 'C')
            {
                e.Handled = true;
            }
        }


        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}