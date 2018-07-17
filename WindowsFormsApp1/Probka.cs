namespace AluCharpy
{
    public class Probka
    {
        private float _pracaMlotaZuzyta;
        private float _gruboscSciankiProfila;
        private float _odlegloscMiedzyKarbam;

        public string PracaMlotaZuzyta { get; set; }
        public string GruboscSciankiProfila { get; set; }
        public string OdlegloscMiedzyKarbami { get; set; }
        public string RodzajPekniecia { get; set; }

        public int NrProbki { get; set; }
        public float Udarnosc { get; set; }

        public Probka(int nrProbki, string pracaMlotaZuzyta, string gruboscSciankiProfila, string odlegloscMiedzyKarbami, string rodzajPekniecia)
        {
            NrProbki = nrProbki;
            PracaMlotaZuzyta = pracaMlotaZuzyta;
            GruboscSciankiProfila = gruboscSciankiProfila;
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
            bool try1 = float.TryParse(PracaMlotaZuzyta, out _pracaMlotaZuzyta);
            bool try2 = float.TryParse(GruboscSciankiProfila, out _gruboscSciankiProfila);
            bool try3 = float.TryParse(OdlegloscMiedzyKarbami, out _odlegloscMiedzyKarbam);

            return try1 && try2 && try3;

        }
    }
}

