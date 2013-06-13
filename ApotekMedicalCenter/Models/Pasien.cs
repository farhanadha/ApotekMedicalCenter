using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Pasien
    {
        [Key]
        [Required]
        public int IdPasien { set; get; }

        [Required]
        public string NamaPasien { set; get; }
    }
}
