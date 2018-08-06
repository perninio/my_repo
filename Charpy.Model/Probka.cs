using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AluCharpy;
namespace Charpy.Model
{

    public class Probka : ProbkaEF
    {   
        private decimal _pracaMlotaZuzyta;
     
        private string _pracaMlotaZuzytaStr;
        [NotMapped]
        public string PracaMlotaZuzytaStr
        {
            get {return _pracaMlotaZuzytaStr ; }
            set
            {
                _pracaMlotaZuzytaStr = value;
                decimal.TryParse(PracaMlotaZuzytaStr, out _pracaMlotaZuzyta);
                PracaMlotaZuzyta = _pracaMlotaZuzyta;
            }
        }

        private decimal _gruboscSciankiProfila;
     
        private string _gruboscSciankiProfilaStr;
        [NotMapped]
        public string GruboscSciankiProfilaStr
        {
            get { return _gruboscSciankiProfilaStr; }
            set
            {
                _gruboscSciankiProfilaStr = value;
                decimal.TryParse(GruboscSciankiProfilaStr, out _gruboscSciankiProfila);
                GruboscSciankiProfila = _gruboscSciankiProfila;
            }
        }
     
        private decimal _odlegloscMiedzyKarbami;
     
        private string _odlegloscMiedzyKarbamiStr;
        [NotMapped]
        public string OdlegloscMiedzyKarbamiStr
        {
            get { return _odlegloscMiedzyKarbamiStr; }
            set
            {
                _odlegloscMiedzyKarbamiStr = value;
                decimal.TryParse(OdlegloscMiedzyKarbamiStr, out _odlegloscMiedzyKarbami);
                OdlegloscMiedzyKarbami = _odlegloscMiedzyKarbami;
            }
        }
        [NotMapped]
        public string RodzajPeknieciaStr { get; set; }
        [NotMapped]
        public int NrProbki { get; set; }
        [Column("Udarnosc")]
        public decimal Udarnosc { get; set; }


        public WynikBadania WynikBadania { get; set; }
        public int IDBadania { get; set; }
        //konstruktor

        public Probka(int nrProbki, string pracaMlotaZuzyta, string gruboscSciankiProfilaText, string odlegloscMiedzyKarbami, string rodzajPekniecia)
        {
            NrProbki = nrProbki;
            PracaMlotaZuzytaStr = pracaMlotaZuzyta;
            GruboscSciankiProfilaStr = gruboscSciankiProfilaText;
            OdlegloscMiedzyKarbamiStr = odlegloscMiedzyKarbami;
            RodzajPeknieciaStr = rodzajPekniecia;
        }

        public Probka(){}

        public bool LiczUdarnosc()
        {
            Udarnosc = 0;

            var tryParseResult = TryParseInputValues();
            if (!tryParseResult) return false;

            if (_odlegloscMiedzyKarbami == 0 || _gruboscSciankiProfila == 0)
            {
                return false;
            }

            Udarnosc = (_pracaMlotaZuzyta * 1000) / (_gruboscSciankiProfila * _odlegloscMiedzyKarbami);
            return true;
        }

        private bool TryParseInputValues()
        {
            bool try1 = decimal.TryParse(PracaMlotaZuzytaStr, out _pracaMlotaZuzyta);
            bool try2 = decimal.TryParse(GruboscSciankiProfilaStr, out _gruboscSciankiProfila);
            bool try3 = decimal.TryParse(OdlegloscMiedzyKarbamiStr, out _odlegloscMiedzyKarbami);

            return try1 && try2 && try3;
        }
    }
}

