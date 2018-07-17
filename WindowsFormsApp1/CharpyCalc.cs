using System;
using System.Linq;

namespace AluCharpy
{
    public class CharpyCalc
    {       
        public double RozpietoscWartosciUdarnosci(float[] tab)
        {
            return tab.Max() - tab.Min();
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
