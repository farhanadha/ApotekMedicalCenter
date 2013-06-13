using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{

    public class PengerjaanObat
    {
        [Key]
        [Required]
        public int IdPengerjaanObat { set; get; }

        [Required]
        public int IdApoteker { set; get; }

        [Required]
        public int IdObat { set; get; }

        [ForeignKey("IdPengerjaanObat")]
        public virtual ObatDiadakan PengerjaanObat { set; get; }

        [ForeignKey("IdApoteker")]
        public virtual Apoteker Apoteker { set; get; }

        [ForeignKey("IdObat")]
        public virtual Obat Obat { set; get; }
    }
}
