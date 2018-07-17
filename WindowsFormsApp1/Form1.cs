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
using AluCharpy;
using Charpy.Model;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Probka> Probki;
        public Form1()
        {
            InitializeComponent();
            Probki = new List<Probka>();
        }

        private void Licz_Click(object sender, EventArgs e)
        {
            Probki = new List<Probka>();

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
            //kolumna4
            var probka4 = new Probka(4, tb4Prml.Text, tb4GruScProf.Text, tb4OdlMiWierzKarb.Text, tb4RodzPek.Text);
            Probki.Add(probka4);
            if (probka4.LiczUdarnosc())
            {
                tb4Ud.Text = probka4.Udarnosc.ToString("N4");
            }
            //kolumna5
            var probka5 = new Probka(5, tb5Prml.Text, tb5GruScProf.Text, tb5OdlMiWierzKarb.Text, tb5RodzPek.Text);
            Probki.Add(probka5);
            if (probka5.LiczUdarnosc())
            {
                tb5Ud.Text = probka5.Udarnosc.ToString("N4");
            }
            //kolumna6
            var probka6 = new Probka(6, tb6Prml.Text, tb6GruScProf.Text, tb6OdlMiWierzKarb.Text, tb6RodzPek.Text);
            Probki.Add(probka6);
            if (probka6.LiczUdarnosc())
            {
                tb6Ud.Text = probka6.Udarnosc.ToString("N4");
            }
            //kolumna7
            var probka7 = new Probka(7, tb7Prml.Text, tb7GruScProf.Text, tb7OdlMiWierzKarb.Text, tb7RodzPek.Text);
            Probki.Add(probka7);
            if (probka7.LiczUdarnosc())
            {
                tb7Ud.Text = probka7.Udarnosc.ToString("N4");
            }

            //kolumna8
            var probka8 = new Probka(8, tb8Prml.Text, tb8GruScProf.Text, tb8OdlMiWierzKarb.Text, tb8RodzPek.Text);
            Probki.Add(probka8);
            if (probka8.LiczUdarnosc())
            {
                tb8Ud.Text = probka8.Udarnosc.ToString("N4");
            }

            //kolumna9
            var probka9 = new Probka(9, tb9Prml.Text, tb9GruScProf.Text, tb9OdlMiWierzKarb.Text, tb9RodzPek.Text);
            Probki.Add(probka9);
            if (probka9.LiczUdarnosc())
            {
                tb9Ud.Text = probka9.Udarnosc.ToString("N4");
            }

            //kolumna10
            var probka10 = new Probka(10, tb10Prml.Text, tb10GruScProf.Text, tb10OdlMiWierzKarb.Text, tb10RodzPek.Text);
            Probki.Add(probka10);
            if (probka10.LiczUdarnosc())
            {
                tb10Ud.Text = probka10.Udarnosc.ToString("N4");
            }

            var wynikBadania = new WynikBadania();
            var obliczWynikBadaniaResult = wynikBadania.ObliczWynikBadania(Probki);
            if (obliczWynikBadaniaResult == false)
            {
                //todo:zalogować i pokazać błą
            }

            tbSrUd.Text = wynikBadania.SredniaUdarnosc.ToString("N4");
            tbOdchStd.Text = wynikBadania.Odchylenie.ToString("N4");
            tbEstNieo.Text = wynikBadania.EstymatorNieobciazonyOdchylenia.ToString("N4");
            tbSrGrub.Text = wynikBadania.SredniaGruboscScianki.ToString("N4");
            tbRozpWart.Text = wynikBadania.RozpietoscWartosci.ToString("N4");

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

        private void ClearAllTextBoxes(Control.ControlCollection parentControl)//czyści obraz
        {
            foreach (Control control in parentControl)
            {
                ClearAllTextBoxes(control.Controls);

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

        private void btnUstawOdlegloscKarbow_Click(object sender, EventArgs e)
        {
            var domyslnaOdlegloscKarbow = "3,1";
            tb1OdlMiWierzKarb.Text =
            tb2OdlMiWierzKarb.Text =
            tb3OdlMiWierzKarb.Text =
            tb4OdlMiWierzKarb.Text =
            tb5OdlMiWierzKarb.Text =
            tb6OdlMiWierzKarb.Text =
            tb7OdlMiWierzKarb.Text =
            tb8OdlMiWierzKarb.Text =
            tb9OdlMiWierzKarb.Text =
            tb10OdlMiWierzKarb.Text = domyslnaOdlegloscKarbow;
        }

        private void WyczyscFormularz_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this.Controls);
        }

        private void RodzajPeknieciaTexboxes_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar.ToString().ToUpper();
            if (!RodzajPeknieciaSlownik.RodzajePekniec.Contains(ch))
            {
                e.Handled = true;
            }
        }
    }
}