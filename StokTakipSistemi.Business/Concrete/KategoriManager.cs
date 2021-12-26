using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private Itbl_kategoriDal _KategoriDal;
        public KategoriManager(Itbl_kategoriDal kategoriDal)
        {
            _KategoriDal = kategoriDal;
        }
        public List<tbl_kategori> GetAll()
        {
            return _KategoriDal.GetAll();
        }
    }
}
