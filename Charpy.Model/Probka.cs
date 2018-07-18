using GalaSoft.MvvmLight;

namespace Charpy.Model
{
    public class Probka: ObservableObject
    {
        private double _pracaMlotaZuzyta;
        private double _gruboscSciankiProfila;
        private double _odlegloscMiedzyKarbam;
        private string _pracaMlotaZuzyta1;
        private string _gruboscSciankiProfilaText;
        private string _odlegloscMiedzyKarbami;
        private string _rodzajPekniecia;
        private double _udarnosc;

        public string PracaMlotaZuzyta
        {
            get => _pracaMlotaZuzyta1;
            set { Set(nameof(PracaMlotaZuzyta), ref _pracaMlotaZuzyta1 , value); }
        }

        public string GruboscSciankiProfilaText
        {
            get => _gruboscSciankiProfilaText;
            set
            {
                Set(nameof(GruboscSciankiProfilaText), ref _gruboscSciankiProfilaText, value);
                LiczUdarnosc();
            }
        }

        public string OdlegloscMiedzyKarbami
        {
            get => _odlegloscMiedzyKarbami;
            set
            {
                Set(nameof(OdlegloscMiedzyKarbami), ref _odlegloscMiedzyKarbami, value);
                LiczUdarnosc();
            }
        }

        public string RodzajPekniecia
        {
            get => _rodzajPekniecia;
            set
            {
                Set(nameof(RodzajPekniecia), ref _rodzajPekniecia, value);
                LiczUdarnosc();
            }
        }

        public double GruboscSciankiProfila
        {
            get => _gruboscSciankiProfila;
            set
            {
                Set(nameof(GruboscSciankiProfila), ref _gruboscSciankiProfila, value);
                LiczUdarnosc();
            }
        }

        public int NrProbki { get; set; }

        public double Udarnosc
        {
            get => _udarnosc;
            set { Set(nameof(Udarnosc), ref _udarnosc, value); }
        }

        public Probka()
        {
            
        }

        public Probka(int nrProbki, string pracaMlotaZuzyta, string gruboscSciankiProfilaText, string odlegloscMiedzyKarbami, string rodzajPekniecia)
        {
            NrProbki = nrProbki;
            PracaMlotaZuzyta = pracaMlotaZuzyta;
            GruboscSciankiProfilaText = gruboscSciankiProfilaText;
            OdlegloscMiedzyKarbami = odlegloscMiedzyKarbami;
            RodzajPekniecia = rodzajPekniecia;
            LiczUdarnosc();
        }

        public bool LiczUdarnosc()
        {
            Udarnosc = 0;

            var tryParseResult = TryParseInputValues();
            if (!tryParseResult) return false;

            if (_odlegloscMiedzyKarbam == 0 || _gruboscSciankiProfila == 0)
            {
                return false;
            }

            Udarnosc = (_pracaMlotaZuzyta * 1000) / (_gruboscSciankiProfila * _odlegloscMiedzyKarbam);
            return true;
        }

        private bool TryParseInputValues()
        {
            bool try1 = double.TryParse(PracaMlotaZuzyta, out _pracaMlotaZuzyta);
            bool try2 = double.TryParse(GruboscSciankiProfilaText, out _gruboscSciankiProfila);
            bool try3 = double.TryParse(OdlegloscMiedzyKarbami, out _odlegloscMiedzyKarbam);

            return try1 && try2 && try3;

        }
    }
}

