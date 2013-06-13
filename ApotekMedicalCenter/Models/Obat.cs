using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Obat
    {
        [Key]
        [Required]
        public int IdObat { set; get; }

        [Required]
        public string KodeObat { set; get; }

        [Required]
        public string NamaObat { set; get; }

        [Required]
        public int StokObat { set; get; }

        [Required]
        public int HargaObat { set; get; }

        [Required]
        public string KategoriObat { set; get; }

        [Required]
        public string SatuanObat { set; get; }
    }
}
