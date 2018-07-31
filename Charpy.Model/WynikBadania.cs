using System;
using System.Collections.Generic;
using System.Linq;

namespace Charpy.Model
{
    public class WynikBadania
    {
        const decimal WspolczynikEstymatoraNieobciazonegoOdchylenia = 0.97266M;
        public decimal SredniaUdarnosc { get; set; }
        public decimal Odchylenie { get; set; }
        public decimal EstymatorNieobciazonyOdchylenia { get; set; }
        public decimal SredniaGruboscScianki { get; set; }
        public decimal RozpietoscWartosci { get; set; }

        public bool ObliczWynikBadania(IEnumerable<Probka> probki)
        {
            if (probki == null || probki.Count() <= 1) return false;

            ObliczSredniaUdarnosc(probki);
            ObliczOdchylenie(probki);
            EstymatorNieobciążonyOdchyleniaStandardowego();
            ObliczSredniaGruboscScianek(probki);
            RozpietoscWartosciUdarnosci(probki);

            return true;
        }

        private void ObliczSredniaUdarnosc(IEnumerable<Probka> probki)
        {
            SredniaUdarnosc = probki.Sum(p => p.Udarnosc) / probki.Count();
        }

        private void ObliczOdchylenie(IEnumerable<Probka> probki)
        {

            Odchylenie = (decimal)Math.Sqrt(probki.Sum(x =>Math.Pow((double)x.Udarnosc - (double)SredniaUdarnosc, 2)) / (probki.Count() - 1));
        }

        private void EstymatorNieobciążonyOdchyleniaStandardowego()
        {
            EstymatorNieobciazonyOdchylenia = Odchylenie / WspolczynikEstymatoraNieobciazonegoOdchylenia;
        }

        private void ObliczSredniaGruboscScianek(IEnumerable<Probka> probki)
        {
            SredniaGruboscScianki = probki.Sum(p => p.GruboscSciankiProfila) / probki.Count();
        }
        private void RozpietoscWartosciUdarnosci(IEnumerable<Probka> probki)
        {
            RozpietoscWartosci = probki.Max(p => p.Udarnosc) - probki.Min(p => p.Udarnosc);
        }
    }
}