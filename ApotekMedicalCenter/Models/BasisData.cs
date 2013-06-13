using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMedicalCenter.Models
{
    public class BasisData : DbContext
    {
        public DbSet<Akun> Akun { set; get; }

        public DbSet<Apoteker> Apoteker { set; get; }

        public DbSet<Dokter> Dokter { set; get; }
    }
}
