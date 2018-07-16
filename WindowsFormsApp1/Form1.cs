using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public CharpyCalc Calculator { get; set; }
        public Probka[] tabprob;
        public Form1()
        {
            InitializeComponent();
            Calculator = new CharpyCalc();
            tabprob = new Probka[10];
        }


        //todo: zmienic nazwy buttonow i event handler-ow
        private void Licz_Click(object sender, EventArgs e)//Licz
        {
            float[] wynik = new float[10];
            //kolumna1
            string text1 = tb1Prml.Text;
            string text2 = tb1GruScProf.Text;
            string text3 = tb1OdlMiWierzKarb.Text;
            string znak1= tb1RodzPek.Text;

            float numVal1;
            float numVal2;
            float numVal3;
            float.TryParse(text1, out numVal1);
            float.TryParse(text2, out numVal2);
            float.TryParse(text3, out numVal3);


            wynik[0] = Calculator.Licz_udarnosc(numVal1, numVal2, numVal3);
            tb1Ud.Text = Convert.ToString(wynik[0]);

            //kolumna2
            string text4 = tb2Prml.Text;
            string text5 = tb2GruScProf.Text;
            string text6 = tb2OdlMiWierzKarb.Text;
            string znak2 = tb2RodzPek.Text;

            float numVal4;
            float numVal5;
            float numVal6;
            float.TryParse(text4, out numVal4);
            float.TryParse(text5, out numVal5);
            float.TryParse(text6, out numVal6);

            wynik[1] = Calculator.Licz_udarnosc(numVal4, numVal5, numVal6);
            tb2Ud.Text = Convert.ToString(wynik[1]);

            //kolumna3
            string text7 = tb3Prml.Text;
            string text8 = tb3GruScProf.Text;
            string text9 = tb3OdlMiWierzKarb.Text;

            float numVal7;
            float numVal8;
            float numVal9;
            float.TryParse(text7, out numVal7);
            float.TryParse(text8, out numVal8);
            float.TryParse(text9, out numVal9);
            string znak3 = tb3RodzPek.Text;

            wynik[2] = Calculator.Licz_udarnosc(numVal7, numVal8, numVal9);
            tb3Ud.Text = Convert.ToString(wynik[2]);

            //kolumna4
            string text10 = tb4Prml.Text;
            string text11 = tb4GruScProf.Text;
            string text12 = tb4OdlMiWierzKarb.Text;

            float numVal10;
            float numVal11;
            float numVal12;
            float.TryParse(text10, out numVal10);
            float.TryParse(text11, out numVal11);
            float.TryParse(text12, out numVal12);
            string znak4 = tb4RodzPek.Text;

            wynik[3] = Calculator.Licz_udarnosc(numVal10, numVal11, numVal12);
            tb4Ud.Text = Convert.ToString(wynik[3]);

            //kolumna5
            string text13 = tb5Prml.Text;
            string text14 = tb5GruScProf.Text;
            string text15 = tb5OdlMiWierzKarb.Text;

            float numVal13;
            float numVal14;
            float numVal15;
            float.TryParse(text13, out numVal13);
            float.TryParse(text14, out numVal14);
            float.TryParse(text15, out numVal15);
            string znak5 = tb5RodzPek.Text;

            wynik[4] = Calculator.Licz_udarnosc(numVal13, numVal14, numVal15);
            tb5Ud.Text = Convert.ToString(wynik[4]);

            //kolumna6
            string text16 = tb6Prml.Text;
            string text17 = tb6GruScProf.Text;
            string text18 = tb6OdlMiWierzKarb.Text;

            float numVal16;
            float numVal17;
            float numVal18;
            float.TryParse(text16, out numVal16);
            float.TryParse(text17, out numVal17);
            float.TryParse(text18, out numVal18);
            string znak6 = tb6RodzPek.Text;

            wynik[5] = Calculator.Licz_udarnosc(numVal16, numVal17, numVal18);
            tb6Ud.Text = Convert.ToString(wynik[5]);

            //kolumna7
            string text19 = tb7Prml.Text;
            string text20 = tb7GruScProf.Text;
            string text21 = tb7OdlMiWierzKarb.Text;

            float numVal19;
            float numVal20;
            float numVal21;
            float.TryParse(text19, out numVal19);
            float.TryParse(text20, out numVal20);
            float.TryParse(text21, out numVal21);
            string znak7 = tb7RodzPek.Text;

            wynik[6] = Calculator.Licz_udarnosc(numVal19, numVal20, numVal21);
            tb7Ud.Text = Convert.ToString(wynik[6]);

            //kolumna8
            string text22 = tb8Prml.Text;
            string text23 = tb8GruScProf.Text;
            string text24 = tb8OdlMiWierzKarb.Text;

            float numVal22;
            float numVal23;
            float numVal24;
            float.TryParse(text22, out numVal22);
            float.TryParse(text23, out numVal23);
            float.TryParse(text24, out numVal24);
            string znak8 = tb8RodzPek.Text;

            wynik[7] = Calculator.Licz_udarnosc(numVal22, numVal23, numVal24);
            tb8Ud.Text = Convert.ToString(wynik[7]);
            //
            //kolumna9
            string text25 = tb9Prml.Text;
            string text26 = tb9GruScProf.Text;
            string text27 = tb9OdlMiWierzKarb.Text;

            float numVal25;
            float numVal26;
            float numVal27;
            float.TryParse(text25, out numVal25);
            float.TryParse(text26, out numVal26);
            float.TryParse(text27, out numVal27);
            string znak9 = tb9RodzPek.Text;

            wynik[8] = Calculator.Licz_udarnosc(numVal25, numVal26, numVal27);
            tb9Ud.Text = Convert.ToString(wynik[8]);
            ////
            //kolumna10
            string text28 = tb10Prml.Text;
            string text29 = tb10GruScProf.Text;
            string text30 = tb10OdlMiWierzKarb.Text;

            float numVal28;
            float numVal29;
            float numVal30;
            float.TryParse(text28, out numVal28);
            float.TryParse(text29, out numVal29);
            float.TryParse(text30, out numVal30);
            string znak10 = tb10RodzPek.Text;
            
            wynik[9] = Calculator.Licz_udarnosc(numVal28, numVal29, numVal30);
            tb10Ud.Text = Convert.ToString(wynik[9]);

            //double[] tab = wynik;

            ////
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

    }
}