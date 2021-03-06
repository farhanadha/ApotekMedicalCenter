﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ApotekMedicalCenter.Models;

namespace ApotekMedicalCenter.Controllers
{
    public class AkunController
    {
        BasisData db = new BasisData();
        Pengguna pengguna = new Pengguna();
        
        public bool Register(Dictionary<string, string> registerData)
        {
            if (pengguna.IsExist(registerData["username"]))
            {   
                pengguna.Tambah(registerData);
                return true;
            }
            
            return false;
        }
    }
}
