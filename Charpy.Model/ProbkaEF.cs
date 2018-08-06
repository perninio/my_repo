using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Charpy.Model;

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
        [Column("RodzajPekniecia")]
        public string RodzajPekniecia { get; set; }

        //[ForeignKey("WynikBadania")]
        //public int IDBadania { get; set; }

        public ProbkaEF(){}
     
    }
}
