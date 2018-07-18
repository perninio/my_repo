using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GalaSoft.MvvmLight;

namespace Charpy.Model
{
    public class WynikBadania: ObservableObject
    {
        private double _sredniaUdarnosc;
        private double _odchylenie;
        private double _estymatorNieobciazonyOdchylenia;
        private double _sredniaGruboscScianki;
        private double _rozpietoscWartosci;
        const double WspolczynikEstymatoraNieobciazonegoOdchylenia = 0.97266;

        public double SredniaUdarnosc
        {
            get => _sredniaUdarnosc;
            set { Set(nameof(SredniaUdarnosc), ref _sredniaUdarnosc, value); }
        }

        public double Odchylenie
        {
            get => _odchylenie;
            set { Set(nameof(Odchylenie), ref _odchylenie, value); }
        }

        public double EstymatorNieobciazonyOdchylenia
        {
            get => _estymatorNieobciazonyOdchylenia;
            set { Set(nameof(EstymatorNieobciazonyOdchylenia), ref _estymatorNieobciazonyOdchylenia, value); }
        }

        public double SredniaGruboscScianki
        {
            get => _sredniaGruboscScianki;
            set { Set(nameof(SredniaGruboscScianki), ref _sredniaGruboscScianki, value); }
        }

        public double RozpietoscWartosci
        {
            get => _rozpietoscWartosci;
            set { Set(nameof(RozpietoscWartosci), ref _rozpietoscWartosci, value); }
        }

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
