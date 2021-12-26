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
    }
}
