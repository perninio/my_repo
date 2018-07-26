using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluCharpy
{
    [Table("SlownikRodzajPekniecia")]
    public class SlownikRodzajPekniecia
    {
       [Key, Column("IDRodzajPekniecia")]
        public int IDRodzajPekniecia { get; set; }

       [Column("RodzajPekniecia"), MaxLength(10)]
        public String RodzajPekniecia { get; set; }

    }
}

