using StokTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities.Concrete
{
    public class tbl_kategori:IEntity
    {
        [Key]
        public int kategori_id { get; set; }
        public string kategori_ad { get; set; }
    }
}
