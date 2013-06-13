using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{

    public class PengadaanObat
    {
        [Key]
        [Required]
        public int IdPengadaanObat { set; get; }

        [Required]
        public int IdApoteker { set; get; }

        [Required]
        public int IdPenyedia { set; get; }

        [ForeignKey("IdPengerjaanObat")]
        public virtual ObatDiadakan PengerjaanObat { set; get; }

        [ForeignKey("IdApoteker")]
        public virtual Apoteker Apoteker { set; get; }

        [ForeignKey("IdPenyedia")]
        public virtual Penyedia Penyedia { set; get; }
    }
}
