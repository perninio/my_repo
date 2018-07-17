using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluCharpy
{
    public class WynikBadania
    {
        const double WspolczynikEstymatoraNieobciazonegoOdchylenia = 0.97266;
        public double SredniaUdarnosc { get; set; }
        public double Odchylenie { get; set; }
        public double EstymatorNieobciazonyOdchylenia { get; set; }
        public double SredniaGruboscScianki { get; set; }
        public double RozpietoscWartosci { get; set; }

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
            Odchylenie = Math.Sqrt(probki.Sum(x => Math.Pow(x.Udarnosc - SredniaUdarnosc, 2)) / (probki.Count() - 1));
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
