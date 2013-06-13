using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    
    public class ObatDiadakan
    {
        [Key]
        [Required]
        public int IdObatDiadakan { set; get; }

        [Required]
        public int IdPengadaanObat { set; get; }

        [Required]
        public int IdObat { set; get; }

        [Required]
        public int HargaObat { set; get; }

        [Required]
        public int JumlahObatDiadakan { set; get; }

        [Required]
        public bool StatusPengadaan { set; get; }

        [ForeignKey("IdObat")]
        public virtual Obat Obat { set; get; }

        [ForeignKey("IdPengadaanObat")]
        public virtual PengadaanObat PengadaanObat { set; get; }
    }
}