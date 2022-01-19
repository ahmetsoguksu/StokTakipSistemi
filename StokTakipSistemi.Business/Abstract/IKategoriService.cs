using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Abstract
{
    public interface IKategoriService
    {
        List<tbl_kategori> GetAll();
        List<tbl_kategori> GetCategoriesByCategoryName(string Kategori_ad);
        void Update(tbl_kategori tbl_Kategori);
        void Add(tbl_kategori tbl_kategori);
    }
}
