using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public class CharpyCalc
    {       
        public float RozpietoscWartosciUdarnosci(float[] tab)
        {
            return tab.Max() - tab.Min();
        }


        public float Licz_udarnosc(float val1, float val2, float val3)
        {
            try
            {
                if(val2 ==0 || val3==0)
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Uwaga dzielenie przez 0");
                return 0;
            }
            return (val1 * 1000) / (val2 * val3);
        }

        public float Srednia(float[] tab)
        {
            float wynik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i];
            }
            return wynik / tab.Length;
        }
        ////
        public double StandardDeviation(double[] numberSet)
        {
            double mean = (numberSet.Sum()) / (numberSet.Count());

            return Math.Sqrt(numberSet.Sum(x => Math.Pow(x - mean, 2)) / (numberSet.Count() - 1));
        }

        /////
        public float EstymatorNieobciążonyOdchyleniaStandardowego(float war)
        {
            return war / 0.97266f;
        }
    }
}
