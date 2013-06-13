using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Dokter
    {
        [Key]
        [Required]
        public int IdDokter { set; get; }

        [Required]
        public string NamaDokter { set; get; }

        [Required]
        public int IdAkun { set; get; }

        [ForeignKey("IdAkun")]
        public virtual Akun Akun { set; get; }
    }
}
