using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluCharpy
{

    [Table("Probka")]
    public class ProbkaEF
    {
        [Key, Column("IDProbki")]
        public int IDProbki { get; set; }
        [Column("PracaMlotaZuzytaNaZniszczenieProbki")]
        public decimal PracaMlotaZuzyta { get; set; }
        [Column("GruboscScianki")]
        public decimal GruboscSciankiProfila { get; set; }
        [Column("OdlegloscMiedzyWierzcholkamiKarbow")]
        public decimal OdlegloscMiedzyKarbami { get; set; }
        [Column("IDRodzajPekniecia")]
        public int IDRodzajPekniecia { get; set; }
        public ProbkaEF() { }

    }
}
