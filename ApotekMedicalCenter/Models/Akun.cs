using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Akun
    {
        [Key]
        [Required]
        public int IdAkun { get; set; }
        
        [Required]
        public string Username { set; get; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int HakAkses { set; get; }
    }
}
