using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charpy.Model;

namespace AluCharpy.WPF.ViewModels
{
    public class MainWindowViewModel
    {
        public List<Probka> Probki { get; set; }
        public WynikBadania WynikBadania { get; set; }

        public MainWindowViewModel()
        {
            Probki = new List<Probka>() { new Probka(1, "1", "2", "3", "4"), new Probka(2, "2", "3", "4", "5"),new Probka()};
            WynikBadania = new WynikBadania();
            WynikBadania.ObliczWynikBadania(Probki);
        }
    }
}
