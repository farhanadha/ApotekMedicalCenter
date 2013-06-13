using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekMedicalCenter.Models
{
    public class Penyedia
    {
        [Key]
        [Required]
        public int IdPenyediaObat { set; get; }

        [Required]
        public string NamaPenyediaObat { set; get; }

        [Required]
        public int MinimalFaktur { set; get; }
    }
}
