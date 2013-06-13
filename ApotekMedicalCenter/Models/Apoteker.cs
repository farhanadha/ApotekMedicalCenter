using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Apoteker
    {
        [Key]
        [Required]
        public int IdApoteker { set; get; }

        [Required]
        public string NamaApoteker { set; get; }

        [Required]
        public int IdAkun { set; get; }

        [ForeignKey("IdAkun")]
        public virtual Akun Akun { set; get; }
    }
}
