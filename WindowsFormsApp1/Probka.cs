namespace AluCharpy
{
    public class Probka
    {
        private double _pracaMlotaZuzyta;
        private double _gruboscSciankiProfila;
        private double _odlegloscMiedzyKarbam;

        public string PracaMlotaZuzyta { get; set; }
        public string GruboscSciankiProfilaText { get; set; }
        public string OdlegloscMiedzyKarbami { get; set; }
        public string RodzajPekniecia { get; set; }

        public double GruboscSciankiProfila
        {
            get => _gruboscSciankiProfila;
            set => _gruboscSciankiProfila = value;
        }

        public int NrProbki { get; set; }
        public double Udarnosc { get; set; }

        public Probka(int nrProbki, string pracaMlotaZuzyta, string gruboscSciankiProfilaText, string odlegloscMiedzyKarbami, string rodzajPekniecia)
        {
            NrProbki = nrProbki;
            PracaMlotaZuzyta = pracaMlotaZuzyta;
            GruboscSciankiProfilaText = gruboscSciankiProfilaText;
            OdlegloscMiedzyKarbami = odlegloscMiedzyKarbami;
            RodzajPekniecia = rodzajPekniecia;
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

