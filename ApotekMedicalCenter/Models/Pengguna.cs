using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMedicalCenter.Models
{
    public class Pengguna
    {
        BasisData db = new BasisData();

        public void Tambah(Dictionary<string, string> registerData)
        {
            Akun penggunaBaru = new Akun
            {
                Username = registerData["username"],
                Password = registerData["password"],
                HakAkses = Convert.ToInt32(registerData["hak_akses"])
            };

            db.Akun.Add(penggunaBaru);
            db.SaveChanges();

            int idAkun = penggunaBaru.IdAkun;

            switch (penggunaBaru.HakAkses)
            {
                case 1:
                    TambahApoteker(registerData["nama_pengguna"], idAkun);
                    break;
                case 2:
                    TambahDokter(registerData["nama_pengguna"], idAkun);
                    break;
            };
        }

        private void TambahApoteker(string namaPengguna, int idAkun)
        {
            Apoteker apotekerBaru = new Apoteker
            {
                NamaApoteker = namaPengguna,
                IdAkun = idAkun
            };

            db.Apoteker.Add(apotekerBaru);
            db.SaveChanges();
        }

        public void TambahDokter(string namaPengguna, int idAkun)
        {
            Dokter dokterBaru = new Dokter
            {
                NamaDokter = namaPengguna,
                IdAkun = idAkun
            };

            db.Dokter.Add(dokterBaru);
            db.SaveChanges();
        }

        public bool IsExist(string userName)
        {
            int userExist = 0;
            userExist = (from akun in db.Akun where akun.Username == userName select akun).Count();

            if (userExist == 0)
            {
                return true;
            }

            return false;
        }
    }
}
