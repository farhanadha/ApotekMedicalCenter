using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{

    public class ObatDikerjakan
    {
        [Key]
        [Required]
        public int IdObatDikerjakan { set; get; }

        [Required]
        public int IdResep { set; get; }

        [Required]
        public int IdObat { set; get; }

        [Required]
        public int HargaObat { set; get; }

        [Required]
        public int JumlahObatDikerjakan { set; get; }

        [Required]
        public bool StatusPengerjaan { set; get; }

        [ForeignKey("IdObat")]
        public virtual Obat Obat { set; get; }

        [ForeignKey("IdResep")]
        public virtual Resep Resep { set; get; }
    }
}