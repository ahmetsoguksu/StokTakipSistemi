using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Abstract
{
    public interface IUrunService
    {
        List<tbl_urun> GetAll();
        List<tbl_urun> GetProductsByCategory(int Kategori_id);
        List<tbl_urun> GetProductsByProductName(string Urun_ad);
        void Add(tbl_urun tbl_urun);
        void Update(tbl_urun tbl_urun);
        void Delete(tbl_urun tbl_urun);
    }
}
