using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Resep
    {
        [Key]
        [Required]
        public int IdResep { set; get; }

        [Required]
        public int IdObat { set; get; }

        [Required]
        public int IdPasien { set; get; }

        [Required]
        public int IdDokter { set; get; }

        [Required]
        public int IdApoteker { set; get; }

        [Required]
        public DateTime Tanggal { set; get; }

        public string verifikasiApoteker { set; get; }
        
        public string verifikasiDokter { set; get; }

        public bool statusVerifikasi { set; get; }

        [ForeignKey("IdObat")]
        public virtual Obat Obat { set; get; }

        [ForeignKey("IdPasien")]
        public virtual Pasien Pasien { set; get; }

        [ForeignKey("IdDokter")]
        public virtual Dokter Dokter { set; get; }

        [ForeignKey("IdApoteker")]
        public virtual Apoteker Apoteker { set; get; }

    }
}
