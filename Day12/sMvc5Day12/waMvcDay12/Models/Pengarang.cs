using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace waMvcDay12.Models
{
    public class Pengarang
    {
        public int ID { get; set; }
        [Display(Name="Kode Pengarang")]
        public string Kd_Pengarang { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
        public jnsKelamin Kelamin { get; set; }
    }

    public enum jnsKelamin
    {
        P, // P for Pria
        W // W for Wanita
    }
}