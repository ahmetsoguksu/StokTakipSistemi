using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities.Concrete
{
    public class tbl_kullanici
    {
        [Key]
        public int kullanici_id { get; set; }
        public string kullanici_ad { get; set; }
        public string kullanici_parola_hash { get; set; }
        public bool kullanici_seviye { get; set; }

    }
}
