using StokTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities.Concrete
{
    public class tbl_urun:IEntity
    {
        [Key]
        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public int kategori_id { get; set; }
        public string urun_birim { get; set; }
        public int urun_stok_miktari { get; set; }
        public decimal urun_kdv_orani { get; set; }
        public decimal urun_son_alis_fiyati { get; set; }
        public decimal urun_son_satis_fiyati { get; set; }
    }
}
